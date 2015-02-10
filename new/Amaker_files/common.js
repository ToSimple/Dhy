(function(){
	console.log('welcome to Amaker platform.');

	// get the default act 
	if(true){
		ACT = 'click';
	}else{
		ACT = 'tap';
	}

	// click my profile
	$('#J_nick').on(ACT, function(){
		var _ = $(this);
		_.parent().find('.auto_list').slideToggle(200);
		return false;
	})

	// check if the elem is belongs an dom area
	function is_area(elem, classname){
		return elem.hasClass(classname) || elem.parents('.'+classname).length > 0;
	}

	$('body').on(ACT, function(e){
		var t = $(e.target);

		// hide all auto list when click body
		if(!is_area(t, 'search_form') && !is_area(t, 'nick')){
			$('.auto_list').fadeOut(200);
		}

		// hide sidemenu when click body
		if(!is_area(t, 'side_menu')){
			$('#J_sidemenu').removeClass('showing');
		}
	})

	// focus search input
	var search_func = 0;
	function search(autolist, val){
		var keyword = $.trim(val) || '';
		if(autolist.data('prev') == keyword){
			if(autolist.children('ul').html().indexOf('loading...')==-1){
				autolist.show();
			}else{
				autolist.hide();
			}
			return false;
		}
		autolist.data('prev', keyword);
		clearTimeout(search_func);
		autolist.show().children('ul').html('<li><p class="tc">loading...</p></li>');
		search_func = setTimeout(function(){
			$.get('/search/keyword', {
				word : keyword
			}, function(data){
				var tmpl = '';
				$.each(data.result, function(){
					tmpl += '<li><a href="/proj/list?word='+this.word+'">'+this.word+'</a></li>';
				})
				autolist.show().children('ul').html(tmpl);
			}, 'json')
		}, 500)
	}
	$('#J_searchinput').on('keyup ' + ACT, function(e){
		var _ = $(this);
		search(_.parent().parent().find('.auto_list'), _.val());
	})
	$('#J_searchForm').on('submit', function(){
		var val = $('#J_searchinput').val();
		return !!$.trim(val);
	})

	// modal definition
	$('[data-modal]').on(ACT, function(){
		var _ = $(this);
		var modal = $(_.data('modal'));
		modal.fadeIn(200, function(){
			$(this).children('.modal').show(400);
		});
		return false;
	})
	$('.modal_wrap').on(ACT, '.close', function(){
		var modal = $($(this).parents('.modal_wrap')[0]);
		modal.children('.modal').hide(400, function(){
			modal.fadeOut(200);
		})
		return false;
	}).on('scroll', function(e){
		e.stopPropagation && e.stopPropagation();
	})
	
	// sub block form
	$('.sub_block').on(ACT, '.toggle', function(){
		var _ = $(this);
		var parent = $(_.parents('.sub_block')[0]);
		var form = parent.find('.form');
		if(form.is(':visible')){
			form.slideUp(200);
			_.html(LANGUAGE.down + ' <i class="fa fa-angle-double-down"></i>');
		}else{
			parent.siblings().find('.form').slideUp(200);
			parent.siblings().find('.toggle').html(LANGUAGE.down + ' <i class="fa fa-angle-double-down"></i>');
			form.slideDown(200);
			_.html(LANGUAGE.up + ' <i class="fa fa-angle-double-up"></i>');
		}
	})

	// captcha
	var captcha_row = $('.captcha_row');
	captcha_row.find('img').bind(ACT, function(){
		var _ = $(this);
		_.attr('src', '/captcha?t=' + (new Date).getTime());
	}).css('cursor', 'pointer');
	captcha_row.find('input').bind('keyup', function(){
		var _ = $(this);
		var input_captcha = _.val();
		if(input_captcha.length >= 4){
			$.get('/async_captcha', function(code){
				var tip = _.parent().children('.j_tip');
				if(input_captcha != code){
					tip.removeClass('font_color_green').addClass('font_color_red').show().html(LANGUAGE['error captcha']);
				}else{
					tip.removeClass('font_color_red').addClass('font_color_green').show().html('<i class="fa fa-check"></i>');
				}
			}, 'json')
		}
	}).bind('blur', function(){
		var _ = $(this);
		var input_captcha = _.val();
		var tip = _.parent().children('.j_tip');
		if(input_captcha.length < 4){
			tip.removeClass('font_color_green').addClass('font_color_red').show().html(LANGUAGE['error captcha']);
		}
	})

	// prevent form multiple submit
	$('form [type=submit]').click(function(){
		var _ = $(this);
		if(_.hasClass('disabled')){
			return false;
		}

		_.addClass('disabled');
		return true;
	})

	// ajax submit form
	$.fn.ajaxSubmit = function(callback){
		var _ = this;
		var inputs = _.find('[name]');
		var params = {};
		inputs.each(function(idx, item){
			var _ = $(item);
			_.trigger('blur');
			if(_.attr('type') != 'file'){
				params[_.attr('name')] = _.val();
			}
		})

		var pass = true;

    _.find('.j_tip').each(function(){
      var tip = $(this);
      if(tip.is(':visible') && tip.hasClass('font_color_red')){
        pass = false;
      }
    })
    if(!pass){
      _.find('[type=submit]').removeClass('disabled');
      return false;
    }

    var req_url = _.attr('action');

    $.post(req_url, params, function(data){
    	callback(data);
    }, 'json')
	}

	// hide alert
	var alert = $('.alert');
	if(alert.length){
		setTimeout(function(){
			alert.fadeOut(2000);
		}, 4000);
	}

	// stars operation
	var stars = $('.j_stars');
	stars.each(function(){
		var _ = $(this);
		_.find('.fa-star').each(function(){
			$(this).on('mouseover', function(){
				var _ = $(this);
				var idx = _.index();
				_.parent().children().removeClass('light').each(function(i){
					var _ = $(this);
					if(i < idx){
						_.addClass('light');
					}else{
						return false;
					}
				})
			}).on('mouseout', function(){
				var _ = $(this);
				_.parent().children().removeClass('light');
			}).on('click', function(){
				var _ = $(this);
				
				var idx = _.index();
				_.parent().children().removeClass('light lighted').each(function(i){
					var _ = $(this);
					if(i < idx){
						_.addClass('light lighted');
					}else{
						return false;
					}
				});
				_.addClass('light lighted');
				var input = _.parent().find('input[type=hidden]').val(idx+1);
				_.parent().next('.j_tip').hide();
			})
		})
	})

	// loading
	$('body').append('<div id="_loading" class="loading hide">loading...</div>');
	window.show_loading = function(){
		$('#_loading').fadeIn();
	}
	window.hide_loading = function(){
		$('#_loading').fadeOut();
	}

	// href detect
	function href_detect(text) {
		if(text.indexOf('www.') === 0){
			var urlRegex = /(www.[^\s]+)/g;
		  return text.replace(urlRegex, function(url) {
		    return '<a href="//' + url + '">' + url + '</a>';
		  })
		}else if(text.indexOf('http') === 0){
			var urlRegex = /(https?:\/\/[^\s]+)/g;
		  return text.replace(urlRegex, function(url) {
		    return '<a href="' + url + '">' + url + '</a>';
		  })
		}

		return text;
	}
	$('.j_href').each(function(){
		var _ = $(this);
		var val = _.html();
		_.html(href_detect(val));
	})

	// #########  for mobile

	// show side menu
	$('#J_showsidemenu').on(ACT, function(){
		$('#J_sidemenu').toggleClass('showing');
		return false;
	})
}());

(function(){

	window.login_wrap = function(cb){
		if(window.USER && USER.id){
			cb && cb.call();
			return true;
		}else{
			$('#J_loginModal').fadeIn(200, function(){
				$(this).children('.modal').show(400).find('[name=next]').val(location.pathname);
			}).find('input').val('');
			return false;
		}
	}

	$('#J_loginModal form').submit(function(){
		var _ = $(this);
		$.post('/auth/login', {
			email : _.find('[name=email]').val(),
			password : _.find('[name=password]').val(),
			keeplogin : _.find('[name=keeplogin]').is(':checked') ? 1 : 0,
			async : 1
		}, function(data){
			if(data.status){
				location.reload();
			}else{
				alert(data.msg);
			}
			_.find('button').removeClass('disabled');
		}, 'json')

		return false;
	})
}());
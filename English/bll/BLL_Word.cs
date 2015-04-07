using English.help;
using English.Helpers;
using English.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace English.bll
{
    public class BLL_Word
    {

        public static int Add(Word model)
        {
            var _repo = SS.GetRepo();
            _repo.Add<Word>(model);
            if (model.Id != 0)
            {
                return model.Id;
            }
            else
            {
                return 0;
            }
        }

        public static List<Word> Find()
        {
            return null;
        }
    }
}
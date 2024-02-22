using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HumanFacade
    {
        Work _work;
        Chores _chores;
        Leisure _leisure;

        public HumanFacade(Work work, Chores chores, Leisure leisure)
        {
            _chores = chores;
            _leisure = leisure;
            _work = work;
        }
        public void DoWork()
        {
            _work.WriteCode();
            _work.OptimizeSystem();
            _work.HaveMeeting();
        }
        public void DoSomeWork()
        {
            _work.HaveMeeting();
        }

        public void DoChores()
        {
            _chores.WashDishes();
            _chores.MopFloor();
            _chores.WipeWindows();
        }
        public void DoLeisure()
        {
            _leisure.ReadBook();
            _leisure.WathcMovie();
        }

    }
}

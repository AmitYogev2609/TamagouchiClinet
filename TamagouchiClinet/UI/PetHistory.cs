using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TamagouchiClinet.DataTransferObjects;

namespace TamagouchiClinet
{
    class PetHistory:screen
    {
        public PetHistory() : base("your pet history")
        {

        }
        public override void Show()
        {
            base.Show();
            Task<List<FunctionDTO>> functions = UIMain.WebAPI.GetFunctions();
            functions.Wait();
            ObjectsList historyOfFunction = new ObjectsList("History of the pet action",functions.Result.ToList<object>());
            historyOfFunction.Show();

            Console.ReadKey();
        }
    }
    
}

namespace GSMMain
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {

        // На 12-та задачка последните точки доста се мъчих така и неуспях да ги подкарам. Неможах да установя защо не ми извиква методите...
        static void Main()
        {
            GSM htc = new GSM("HTC ONE", "HTC Corp", 419.99, "Martin");
            GSM samsung = new GSM("Galaxy S5", "Samsung", 700.99, "Ivan");
            GSM nokia = new GSM("3310", "Nokia", 10.99, "Stefan", new Battery(BatteryType.NiCd, 48, 8), new Display(1.5, 2));

            List<GSM> telephones = new List<GSM>();

            telephones.Add(htc);
            telephones.Add(samsung);
            telephones.Add(GSM.IPhone4S);
            telephones.Add(nokia);

            Console.WriteLine(String.Join("\n", telephones));
            Console.WriteLine();
            

            Call firstCall = new Call(new DateTime(2012, 8, 21, 23, 32, 15), "+359886454545", 120);
            Call secondCall = new Call(DateTime.Now, "+359878212121", 745);
            Call thirdCall = new Call(DateTime.Now, "+0898000001", 512);
            
            //example
            htc.AddCall(firstCall);
            htc.AddCall(secondCall);
            htc.AddCall(thirdCall);
            htc.CalculatePrice(pricePerMinute);

            Console.WriteLine(String.Join("\n", callHistory));
           
            
        }
    }
}

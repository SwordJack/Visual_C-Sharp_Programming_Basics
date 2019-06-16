using System;

namespace Lab_Ch8_4
{
    public class BankAccount
    {
        public static int totalBankCount = 0;   //创建新账户总数。
        string _bankAccountID;                  //账户名称。
        double _bankAccountDeposit;             //账户存款。


        //
        //（构造函数）创建新账户时不存款。
        //
        public BankAccount(string accountID)
        {
            _bankAccountID = accountID;
            _bankAccountDeposit = 0;
        }


        //
        //（构造函数）创建新账户并存款。
        //
        public BankAccount(string accountID, double initialSave)
        {
            _bankAccountID = accountID;
            _bankAccountDeposit = initialSave;
        }


        //
        //“账户名称”可认为并用“属性”的方式设置为是只读的字段。
        //
        public string AccountID
        {
            get
            {
                return _bankAccountID;
            }
        }


        //
        //查询账户情况。
        //
        public void Inquiry()
        {
            Console.WriteLine("账户名称：{0}，存款：{1}；", this.AccountID, this._bankAccountDeposit);
        }


        //
        //获取创建的账户总数。
        //
        public static void TotalAccountDisplay()
        {
            Console.WriteLine("账户总数：{0}", totalBankCount);
        }
    }
}

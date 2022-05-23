using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace NumberLogic
{
    public class DictonaryWin <T>
    {
        readonly string winningNumbers;
        public int[] winNum = { 0,0,0,0,0};
        public DictonaryWin(string winningNumbers) { this.winningNumbers = winningNumbers; }
        public List<DictonaryWin> tValue = new List<DictonaryWin>();
    }
}

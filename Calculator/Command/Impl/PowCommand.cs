﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.Command
{
    public class PowCommand : AbstractCommand
    {

        private static string POW_SYMBOL = " ^ ";

        public PowCommand(Button button) : base(button)
        {
        }

        public override double Calculate()
        {
            CommandRecorder.Record(this);
            return Snapshot.Arguments.pow();
        }

        public override string getSign()
        {
            return POW_SYMBOL;
        }
    }
}

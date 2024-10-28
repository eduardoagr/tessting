using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace tessting.Model {

    public class TurbinePin {

        public ICommand? PinClickedCommand { get; set; }

        public Turbine? Turbine { get; set; }

    }
}

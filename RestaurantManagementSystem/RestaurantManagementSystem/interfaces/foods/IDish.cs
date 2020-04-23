using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces.foods
{
    public interface IDish<EType> : IMenuItem
    {
        public EType Type { get; set; }
    }
}

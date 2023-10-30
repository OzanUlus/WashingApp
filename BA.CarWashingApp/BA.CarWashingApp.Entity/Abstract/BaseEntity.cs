using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}

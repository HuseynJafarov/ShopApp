using Domain.Entities;
using Repository.Data;
using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Implementation
{
    public class SliderBoxsRepository : Repository<SliderBoxs> , ISliderBoxsRepository
    {
        public SliderBoxsRepository( AppDbContext context) : base(context) 
        {
            
        }
    }

}

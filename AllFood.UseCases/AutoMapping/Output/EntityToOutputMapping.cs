using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFood.UseCases.AutoMapping.Output
{
    public class EntityToOutputMapping: Profile
    {
        public EntityToOutputMapping() { 
        
            CreateMap<DataBase.Entities.User, Domain.Entities.User>();

        }
    }
}


using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WP.Cooking.GESE.WebAPI.Models;
using GraphQL.DataLoader;
using WP.Cooking.GESE.WebAPI.Repositories; 


namespace WP.Cooking.GESE.WebAPI.GraphQL.Types
{
    public partial class PrmReadSrmultiplexGraphType : ObjectGraphType<PrmReadSrmultiplex>
    {
        public PrmReadSrmultiplexGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfInputPins, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin4, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin5, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin6, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin7, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin8, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin9, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin10, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin11, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin12, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin13, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin14, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin15, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.InputPin16, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.SelectPin, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.FeedbackPin, type: typeof(ByteGraphType), nullable: True);
            
        }
    }
}
            
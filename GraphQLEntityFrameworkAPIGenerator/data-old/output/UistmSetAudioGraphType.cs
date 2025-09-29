
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
    public partial class UistmSetAudioGraphType : ObjectGraphType<UistmSetAudio>
    {
        public UistmSetAudioGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.AudioLabel, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.OverrideMasterVolume, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Volume, type: typeof(ByteGraphType), nullable: True);
            
        }
    }
}
            
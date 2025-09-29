
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
    public partial class PrmReadAccellerometerStlisxDhGraphType : ObjectGraphType<PrmReadAccellerometerStlisxDh>
    {
        public PrmReadAccellerometerStlisxDhGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrmReadAccellerometerStlisxDhid, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Fifo, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Res, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cport, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2cspd, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.I2caddress, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Xa, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Ya, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Za, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Bdu, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Be, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Tr, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Scale, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.DataRate, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.XaxisOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.YaxisOptions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ZaxisOptions, type: typeof(ByteGraphType), nullable: False);
            
            Field<PrmReadAccellerometerGraphType, PrmReadAccellerometer>("PrmReadAccellerometers")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmReadAccellerometerGraphType>>(
                        "PrmReadAccellerometerStlisxDh-PrmReadAccellerometer-loader",
                        async ids => 
                        {
                            var data = await dbContext.PrmReadAccellerometers
                                .Where(x => x.PrmReadAccellerometer != null && ids.Contains((Guid)x.PrmReadAccellerometer))
                                .Select(x => new
                                {
                                    Key = (Guid)x.PrmReadAccellerometer!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.PrmReadAccellerometers);
                });
            
        }
    }
}
            
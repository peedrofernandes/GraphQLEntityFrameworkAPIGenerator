
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
    public partial class InductionZeroCrossConfigurationGraphType : ObjectGraphType<InductionZeroCrossConfiguration>
    {
        public InductionZeroCrossConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ZeroCrossConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.HeatSink0Giid, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.HeatSink1Giid, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<InductionIpcdetailGraphType, InductionIpcdetail>("InductionIpcdetails")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<InductionIpcdetailGraphType>>(
                        "InductionZeroCrossConfiguration-InductionIpcdetail-loader",
                        async ids => 
                        {
                            var data = await dbContext.InductionIpcdetails
                                .Where(x => x.InductionIpcdetail != null && ids.Contains((Guid)x.InductionIpcdetail))
                                .Select(x => new
                                {
                                    Key = (Guid)x.InductionIpcdetail!,
                                    Value = x,
                                })
                                .ToListAsync();
                        });

                    return loader.LoadAsync(context.Source.InductionIpcdetails);
                });
            
			
            Field<InductionInverterChannelConfigurationGraphType, InductionInverterChannelConfiguration>("InductionInverterChannelConfigurations")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionInverterChannelConfigurationGraphType>(
                        "InductionZeroCrossConfiguration-InductionInverterChannelConfiguration-loader",
                        async ids => 
                        {
                            Expression<Func<InductionInverterChannelConfiguration, bool>> expr = x => !ids.Any()
                                \|\| (x.InverterChannel0 != null && ids.Contains((Guid)x.InverterChannel0))
\|\| (x.InverterChannel1 != null && ids.Contains((Guid)x.InverterChannel1));

                            var data = await dbContext.InductionInverterChannelConfigurations
                                .Where(expr)
                                .ToListAsync();

                            var lookup = data
                                .SelectMany(x => new List<Guid?>()
                                {
                                    x.InverterChannel0,
x.InverterChannel1
                                }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                .ToLookup(x => x.Key, x => x.Value);

                            return lookup;
                        });

                    return loader.LoadAsync(context.Source.InductionInverterChannelConfigurations);
                });
            
        }
    }
}
            
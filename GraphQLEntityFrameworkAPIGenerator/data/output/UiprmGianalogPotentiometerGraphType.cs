
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
    public partial class UiprmGianalogPotentiometerGraphType : ObjectGraphType<UiprmGianalogPotentiometer>
    {
        public UiprmGianalogPotentiometerGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Min, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Max, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ValMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ValMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SatMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SatMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RangeMin, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RangeMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EnableRangeDetection, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.A, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.B, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.C, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.TimeStamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
            Field<TableTargetGraphType, TableTarget>("TableTargets")
                .ResolveAsync(context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TableTargetGraphType>(
                        "UiprmGianalogPotentiometer-TableTarget-loader",
                        async ids => 
                        {
                            var data = await dbContext.TableTargets
                                .Where(x => x.TableTarget != null && ids.Contains((byte)x.TableTarget))
                                .Select(x => new
                                {
                                    Key = (byte)x.TableTarget!,
                                    Value = x,
                                })
                                .ToListAsync();

                            return data.ToLookup(x => x.Key, x => x.Value);
                        });

                    return loader.LoadAsync(context.Source.TableTarget);
                });
            
        }
    }
}
            
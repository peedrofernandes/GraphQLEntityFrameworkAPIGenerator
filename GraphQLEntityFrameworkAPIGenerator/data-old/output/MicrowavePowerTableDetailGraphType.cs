
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
    public partial class MicrowavePowerTableDetailGraphType : ObjectGraphType<MicrowavePowerTableDetail>
    {
        public MicrowavePowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.MicrowavePowerTableDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PowerLabel, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Smpsduty, type: typeof(FloatGraphType), nullable: False);
			Field(t => t.OnTime, type: typeof(FloatGraphType), nullable: False);
            
                Field<MicrowavePowerTableConfigurationsMicrowavePowerTableDetailGraphType, MicrowavePowerTableConfigurationsMicrowavePowerTableDetail>("MicrowavePowerTableConfigurationsMicrowavePowerTableDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<MicrowavePowerTableConfigurationsMicrowavePowerTableDetailGraphType>>(
                            "{ Name = EntityName "MicrowavePowerTableDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "MicrowavePowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "MicrowavePowerTableDetailsId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "PowerLabel"
                                                        IsNullable = false };
         Primitive { Type = Float
                     Name = "Smpsduty"
                     IsNullable = false }; Primitive { Type = Float
                                                       Name = "OnTime"
                                                       IsNullable = false };
         Navigation
           { Type =
              TableName
                "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
             Name =
              "MicrowavePowerTableConfigurationsMicrowavePowerTableDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "MicrowavePowerTableDetailsId"
      Type = Id Guid
      IsNullable = false }; { Name = "PowerLabel"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Smpsduty"
                                                      Type = Primitive Float
                                                      IsNullable = false };
    { Name = "OnTime"
      Type = Primitive Float
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name =
         RelationName
           "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
        TargetTable =
         { Name =
            TableName
              "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "MicrowavePowerTableDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "MicrowavePowerTableConfiguration"
                          Name = "MicrowavePowerTableConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MicrowavePowerTableDetail"
                          Name = "MicrowavePowerTableDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "MicrowavePowerTableConfigurationsMicrowavePowerTableDetail"
        KeyType = Guid }] }-MicrowavePowerTableConfigurationsMicrowavePowerTableDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.MicrowavePowerTableConfigurationsMicrowavePowerTableDetails
                                    .Where(x => x.MicrowavePowerTableConfigurationsMicrowavePowerTableDetail != null && ids.Contains((Guid)x.MicrowavePowerTableConfigurationsMicrowavePowerTableDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.MicrowavePowerTableConfigurationsMicrowavePowerTableDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.MicrowavePowerTableConfigurationsMicrowavePowerTableDetails);
                    });
            
        }
    }
}
            
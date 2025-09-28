
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
    public partial class InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType : ObjectGraphType<InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail>
    {
        public InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InductionCoilPowerTableConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.InductionCoilPowerTableDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<InductionCoilPowerTableConfigurationGraphType, InductionCoilPowerTableConfiguration>("InductionCoilPowerTableConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableConfigurationGraphType>(
                            "{ Name =
   EntityName
     "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionCoilPowerTableDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableDetail"
                      Name = "InductionCoilPowerTableDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionCoilPowerTableConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionCoilPowerTableDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableDetail"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Wattage"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "Timeout"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReturnLevel"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableDetail"
        IsNullable = false
        KeyType = Guid }] }-InductionCoilPowerTableConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilPowerTableConfigurations
                                    .Where(x => x.InductionCoilPowerTableConfiguration != null && ids.Contains((Guid)x.InductionCoilPowerTableConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilPowerTableConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilPowerTableConfiguration);
                });
            
			
                Field<InductionCoilPowerTableDetailGraphType, InductionCoilPowerTableDetail>("InductionCoilPowerTableDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, InductionCoilPowerTableDetailGraphType>(
                            "{ Name =
   EntityName
     "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "InductionCoilPowerTableConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "InductionCoilPowerTableDetailId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "InductionCoilPowerTableConfiguration"
                      Name = "InductionCoilPowerTableConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "InductionCoilPowerTableDetail"
                      Name = "InductionCoilPowerTableDetail"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "InductionCoilPowerTableConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "InductionCoilPowerTableDetailId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableConfiguration"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableConfigId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Description"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Status"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Owner"
                                                           IsNullable = false };
             Primitive { Type = DateTime
                         Name = "Timestamp"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "RevisionGroup"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Revision"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "TableTarget"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Notes"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "BoosterLevel"
                         IsNullable = false };
             Navigation { Type = TableName "InductionCoilChannel"
                          Name = "InductionCoilChannels"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InductionCoilConfig"
                          Name = "InductionCoilConfigs"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "InductionCoilPowerTableDetail"
        TargetTable =
         { Name = TableName "InductionCoilPowerTableDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "InductionCoilPowerTableDetailId"
                          IsNullable = false }; Primitive { Type = Int
                                                            Name = "Wattage"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "Timeout"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ReturnLevel"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetail"
                 Name =
                  "InductionCoilPowerTableConfigurationsInductionCoilPowerTableDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "InductionCoilPowerTableDetail"
        IsNullable = false
        KeyType = Guid }] }-InductionCoilPowerTableDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.InductionCoilPowerTableDetails
                                    .Where(x => x.InductionCoilPowerTableDetail != null && ids.Contains((Guid)x.InductionCoilPowerTableDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.InductionCoilPowerTableDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InductionCoilPowerTableDetail);
                });
            
        }
    }
}
            
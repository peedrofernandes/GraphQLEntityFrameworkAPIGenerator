
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
    public partial class PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration>
    {
        public PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerBroilConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerBroilUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerBroilConfigurationGraphType, PrtimerBroilConfiguration>("PrtimerBroilConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilConfigurationGraphType>(
                            "{ Name =
   EntityName "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilConfiguration"
                      Name = "PrtimerBroilConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                      Name = "PrtimerBroilUserPhaseNameConfig"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilConfigurations
                                    .Where(x => x.PrtimerBroilConfiguration != null && ids.Contains((Guid)x.PrtimerBroilConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilConfiguration);
                });
            
			
                Field<PrtimerBroilUserPhaseNameConfigurationGraphType, PrtimerBroilUserPhaseNameConfiguration>("PrtimerBroilUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerBroilUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerBroilConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerBroilUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerBroilConfiguration"
                      Name = "PrtimerBroilConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PrtimerBroilUserPhaseNameConfiguration"
                      Name = "PrtimerBroilUserPhaseNameConfig"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerBroilConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerBroilUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerBroilConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilConfigId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Version"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
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
                         Name = "NumberOfLevels"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "PrtimerBroilTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "PrtimerBroilTimerLimitConfiguration"
                          Name = "PrtimerBroilTimerLimitConfig"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrtimerBroilConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerBroilUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerBroilUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerBroilUserPhaseNameConfigId"
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
             Primitive { Type = Short
                         Name = "UserPhaseName"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumberOfLevels"
                         IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfiguration"
                 Name =
                  "PrtimerBroilConfigurationPrtimerBroilUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetail"
                 Name =
                  "PrtimerBroilUserPhaseNameConfigurationPrtimerBroilUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerBroilUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerBroilUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerBroilUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerBroilUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerBroilUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerBroilUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerBroilUserPhaseNameConfiguration);
                });
            
        }
    }
}
            
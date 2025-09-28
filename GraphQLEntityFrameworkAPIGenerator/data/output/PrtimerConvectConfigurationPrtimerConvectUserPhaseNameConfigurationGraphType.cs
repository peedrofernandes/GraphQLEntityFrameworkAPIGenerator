
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
    public partial class PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType : ObjectGraphType<PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration>
    {
        public PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerConvectUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerConvectConfiguration"
                      Name = "PrtimerConvectConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
             Name = "PrtimerConvectUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
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
                          Name = "PrtimerConvectTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
                 Name =
                  "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
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
                    "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
                 Name =
                  "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
                 Name =
                  "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerConvectConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectConfigurations
                                    .Where(x => x.PrtimerConvectConfiguration != null && ids.Contains((Guid)x.PrtimerConvectConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectConfiguration);
                });
            
			
                Field<PrtimerConvectUserPhaseNameConfigurationGraphType, PrtimerConvectUserPhaseNameConfiguration>("PrtimerConvectUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation { Type = TableName "PrtimerConvectConfiguration"
                      Name = "PrtimerConvectConfig"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
             Name = "PrtimerConvectUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectUserPhaseNameConfigId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PrtimerConvectConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectConfigId"
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
                          Name = "PrtimerConvectTimerLimitConfigId"
                          IsNullable = true };
             Navigation { Type = TableName "PowerReductionTimerConfiguration"
                          Name = "PowerReductionTimerConfigurations"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
                 Name =
                  "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = true
                 IsCollection = false }] }
        Destination = EntityName "PrtimerConvectConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectUserPhaseNameConfiguration"
        TargetTable =
         { Name = TableName "PrtimerConvectUserPhaseNameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameConfigId"
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
                    "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfiguration"
                 Name =
                  "PrtimerConvectConfigurationPrtimerConvectUserPhaseNameConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
                 Name =
                  "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectUserPhaseNameConfiguration"
        IsNullable = false
        KeyType = Guid }] }-PrtimerConvectUserPhaseNameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectUserPhaseNameConfigurations
                                    .Where(x => x.PrtimerConvectUserPhaseNameConfiguration != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectUserPhaseNameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameConfiguration);
                });
            
        }
    }
}
            
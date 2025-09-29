
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
    public partial class PrtimerConvectTimerLimitConfigurationGraphType : ObjectGraphType<PrtimerConvectTimerLimitConfiguration>
    {
        public PrtimerConvectTimerLimitConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectTimerLimitConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Version, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfLevels, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerConvectConfigurationGraphType, PrtimerConvectConfiguration>("PrtimerConvectConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectConfigurationGraphType>>(
                            "{ Name = EntityName "PrtimerConvectTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitConfigId"
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
         Navigation { Type = TableName "PrtimerConvectConfiguration"
                      Name = "PrtimerConvectConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
             Name =
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerLimitDetail"
                          Name = "PrtimerConvectTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
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
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectConfigurations);
                    });
            
			
                Field<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType, PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail>("PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetailGraphType>>(
                            "{ Name = EntityName "PrtimerConvectTimerLimitConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "PrtimerConvectTimerLimitConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectTimerLimitConfigId"
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
         Navigation { Type = TableName "PrtimerConvectConfiguration"
                      Name = "PrtimerConvectConfigurations"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName
                "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
             Name =
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "PrtimerConvectTimerLimitConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Version"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Description"
                                                      Type = Primitive String
                                                      IsNullable = false };
    { Name = "Status"
      Type = Primitive Byte
      IsNullable = false }; { Name = "Owner"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Timestamp"
                                                      Type = Primitive DateTime
                                                      IsNullable = false };
    { Name = "RevisionGroup"
      Type = Primitive Guid
      IsNullable = false }; { Name = "Revision"
                              Type = Primitive Int
                              IsNullable = false }; { Name = "TableTarget"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Notes"
      Type = Primitive String
      IsNullable = true }; { Name = "NumberOfLevels"
                             Type = Primitive Byte
                             IsNullable = false }]
  Relations =
   [OneToMany
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
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
        TargetTable =
         { Name =
            TableName
              "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "PrtimerConvectTimerLimitDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation
               { Type = TableName "PrtimerConvectTimerLimitConfiguration"
                 Name = "PrtimerConvectTimerLimitConfig"
                 IsNullable = false
                 IsCollection = false };
             Navigation { Type = TableName "PrtimerConvectTimerLimitDetail"
                          Name = "PrtimerConvectTimerLimitDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName
           "PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail"
        KeyType = Guid }] }-PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails
                                    .Where(x => x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail != null && ids.Contains((Guid)x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectTimerLimitConfigurationPrtimerConvectTimerLimitDetails);
                    });
            
        }
    }
}
            
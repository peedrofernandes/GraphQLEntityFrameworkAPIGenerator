
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
    public partial class PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType : ObjectGraphType<PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail>
    {
        public PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.PrtimerConvectUserPhaseNameConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrtimerConvectUserPhaseNameDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PrtimerConvectUserPhaseNameConfigurationGraphType, PrtimerConvectUserPhaseNameConfiguration>("PrtimerConvectUserPhaseNameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectUserPhaseNameConfigurationGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
             Name = "PrtimerConvectUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "PrtimerConvectUserPhaseNameDetail"
                      Name = "PrtimerConvectUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerConvectUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
                 Name =
                  "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectUserPhaseNameDetail"
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
            
			
                Field<PrtimerConvectUserPhaseNameDetailGraphType, PrtimerConvectUserPhaseNameDetail>("PrtimerConvectUserPhaseNameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PrtimerConvectUserPhaseNameDetailGraphType>(
                            "{ Name =
   EntityName
     "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
  CorrespondingTable =
   Regular
     { Name =
        TableName
          "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameConfigId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "PrtimerConvectUserPhaseNameDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         Navigation
           { Type = TableName "PrtimerConvectUserPhaseNameConfiguration"
             Name = "PrtimerConvectUserPhaseNameConfig"
             IsNullable = false
             IsCollection = false };
         Navigation { Type = TableName "PrtimerConvectUserPhaseNameDetail"
                      Name = "PrtimerConvectUserPhaseNameDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "PrtimerConvectUserPhaseNameConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrtimerConvectUserPhaseNameDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PrtimerConvectUserPhaseNameDetail"
        TargetTable =
         { Name = TableName "PrtimerConvectUserPhaseNameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "PrtimerConvectUserPhaseNameDetailsId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "TimerIncrement"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "PowerLimit"
                                                           IsNullable = false };
             Navigation
               { Type =
                  TableName
                    "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetail"
                 Name =
                  "PrtimerConvectUserPhaseNameConfigurationPrtimerConvectUserPhaseNameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "PrtimerConvectUserPhaseNameDetail"
        IsNullable = false
        KeyType = Guid }] }-PrtimerConvectUserPhaseNameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrtimerConvectUserPhaseNameDetails
                                    .Where(x => x.PrtimerConvectUserPhaseNameDetail != null && ids.Contains((Guid)x.PrtimerConvectUserPhaseNameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrtimerConvectUserPhaseNameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PrtimerConvectUserPhaseNameDetail);
                });
            
        }
    }
}
            
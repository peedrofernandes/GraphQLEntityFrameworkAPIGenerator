
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
    public partial class SrexpansionConfigurationsSrexpansionDetailGraphType : ObjectGraphType<SrexpansionConfigurationsSrexpansionDetail>
    {
        public SrexpansionConfigurationsSrexpansionDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SrexpansionConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SrexpansionDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<SrexpansionConfigurationGraphType, SrexpansionConfiguration>("SrexpansionConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrexpansionConfigurationGraphType>(
                            "{ Name = EntityName "SrexpansionConfigurationsSrexpansionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "SrexpansionConfigurationsSrexpansionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SrexpansionConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "SrexpansionDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "AcuexpansionBoardId"
                      IsNullable = false };
         Navigation { Type = TableName "SrexpansionConfiguration"
                      Name = "SrexpansionConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "SrexpansionDetail"
                      Name = "SrexpansionDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "SrexpansionConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "SrexpansionDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "SrexpansionConfiguration"
        TargetTable =
         { Name = TableName "SrexpansionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrexpansionConfigurationsId"
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
             Navigation
               { Type = TableName "SrexpansionConfigurationsSrexpansionDetail"
                 Name = "SrexpansionConfigurationsSrexpansionDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "SrsafetyRelevantParameter"
                          Name = "SrsafetyRelevantParameters"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "SrexpansionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "SrexpansionDetail"
        TargetTable =
         { Name = TableName "SrexpansionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrexpansionDetailsId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicateOverTempCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePlausibilityCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePcbCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePinShortCheckParams"
                         IsNullable = false };
             Navigation
               { Type = TableName "SrexpansionConfigurationsSrexpansionDetail"
                 Name = "SrexpansionConfigurationsSrexpansionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "SrexpansionDetail"
        IsNullable = false
        KeyType = Guid }] }-SrexpansionConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.SrexpansionConfigurations
                                    .Where(x => x.SrexpansionConfiguration != null && ids.Contains((Guid)x.SrexpansionConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SrexpansionConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.SrexpansionConfiguration);
                });
            
			
                Field<SrexpansionDetailGraphType, SrexpansionDetail>("SrexpansionDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SrexpansionDetailGraphType>(
                            "{ Name = EntityName "SrexpansionConfigurationsSrexpansionDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "SrexpansionConfigurationsSrexpansionDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SrexpansionConfigurationsId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "SrexpansionDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "Index"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "AcuexpansionBoardId"
                      IsNullable = false };
         Navigation { Type = TableName "SrexpansionConfiguration"
                      Name = "SrexpansionConfigurations"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "SrexpansionDetail"
                      Name = "SrexpansionDetails"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "SrexpansionConfigurationsId"
      Type = Id Guid
      IsNullable = false }; { Name = "SrexpansionDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "SrexpansionConfiguration"
        TargetTable =
         { Name = TableName "SrexpansionConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrexpansionConfigurationsId"
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
             Navigation
               { Type = TableName "SrexpansionConfigurationsSrexpansionDetail"
                 Name = "SrexpansionConfigurationsSrexpansionDetails"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "SrsafetyRelevantParameter"
                          Name = "SrsafetyRelevantParameters"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "SrexpansionConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "SrexpansionDetail"
        TargetTable =
         { Name = TableName "SrexpansionDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SrexpansionDetailsId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicateOverTempCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePlausibilityCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePcbCheckParams"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "DuplicatePinShortCheckParams"
                         IsNullable = false };
             Navigation
               { Type = TableName "SrexpansionConfigurationsSrexpansionDetail"
                 Name = "SrexpansionConfigurationsSrexpansionDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "SrexpansionDetail"
        IsNullable = false
        KeyType = Guid }] }-SrexpansionDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.SrexpansionDetails
                                    .Where(x => x.SrexpansionDetail != null && ids.Contains((Guid)x.SrexpansionDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SrexpansionDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.SrexpansionDetail);
                });
            
        }
    }
}
            
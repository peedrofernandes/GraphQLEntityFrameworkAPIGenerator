
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
    public partial class PilotMultiSequenceConfigDetailGraphType : ObjectGraphType<PilotMultiSequenceConfigDetail>
    {
        public PilotMultiSequenceConfigDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.DetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotMultiSequenceConfigGraphType, PilotMultiSequenceConfig>("PilotMultiSequenceConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PilotMultiSequenceConfigGraphType>(
                            "{ Name = EntityName "PilotMultiSequenceConfigDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceConfigDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConfigId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "DetailsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceConfig"
                      Name = "Config"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotMultiSequenceDetail"
                      Name = "Details"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "ConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "DetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PilotMultiSequenceConfig"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
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
                         Name = "NumberOfSequence"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequences"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceConfig"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PilotMultiSequenceDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
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
                         Name = "NumberOfSteps"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceDetail"
        IsNullable = false
        KeyType = Guid }] }-PilotMultiSequenceConfig-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceConfigs
                                    .Where(x => x.PilotMultiSequenceConfig != null && ids.Contains((Guid)x.PilotMultiSequenceConfig))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceConfig!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceConfig);
                });
            
			
                Field<PilotMultiSequenceDetailGraphType, PilotMultiSequenceDetail>("PilotMultiSequenceDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PilotMultiSequenceDetailGraphType>(
                            "{ Name = EntityName "PilotMultiSequenceConfigDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "PilotMultiSequenceConfigDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "ConfigId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "DetailsId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "PilotMultiSequenceConfig"
                      Name = "Config"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "PilotMultiSequenceDetail"
                      Name = "Details"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "ConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "DetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "PilotMultiSequenceConfig"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfig"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
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
                         Name = "NumberOfSequence"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequences"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceConfig"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "PilotMultiSequenceDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DetailsId"
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
                         Name = "NumberOfSteps"
                         IsNullable = false };
             Navigation { Type = TableName "PilotMultiSequenceConfigDetail"
                          Name = "PilotMultiSequenceConfigDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PilotMultiSequenceDetailsStep"
                          Name = "PilotMultiSequenceDetailsSteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "PilotMultiSequenceDetail"
        IsNullable = false
        KeyType = Guid }] }-PilotMultiSequenceDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceDetails
                                    .Where(x => x.PilotMultiSequenceDetail != null && ids.Contains((Guid)x.PilotMultiSequenceDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceDetail);
                });
            
        }
    }
}
            
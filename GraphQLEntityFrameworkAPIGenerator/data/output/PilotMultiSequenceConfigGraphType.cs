
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
    public partial class PilotMultiSequenceConfigGraphType : ObjectGraphType<PilotMultiSequenceConfig>
    {
        public PilotMultiSequenceConfigGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumberOfSequence, type: typeof(ByteGraphType), nullable: False);
            
                Field<PilotMultiSequenceConfigDetailGraphType, PilotMultiSequenceConfigDetail>("PilotMultiSequenceConfigDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PilotMultiSequenceConfigDetailGraphType>>(
                            "{ Name = EntityName "PilotMultiSequenceConfig"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "ConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NumberOfSequence"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PilotMultiSequenceConfigDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfigDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "PilotMultiSequenceConfigDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "PrmPilotMultiSequence"
        TargetTable =
         { Name = TableName "PrmPilotMultiSequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotTypeId0"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "PilotParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId1"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "SequencesConfiguration"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceConfig"
                          Name = "SequencesConfigurationNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmPilotMultiSequence"
        KeyType = Guid }] }-PilotMultiSequenceConfigDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.PilotMultiSequenceConfigDetails
                                    .Where(x => x.PilotMultiSequenceConfigDetail != null && ids.Contains((Guid)x.PilotMultiSequenceConfigDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PilotMultiSequenceConfigDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PilotMultiSequenceConfigDetails);
                    });
            
			
                Field<PrmPilotMultiSequenceGraphType, PrmPilotMultiSequence>("PrmPilotMultiSequences")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmPilotMultiSequenceGraphType>>(
                            "{ Name = EntityName "PilotMultiSequenceConfig"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Guid
                                                       Name = "RevisionGroup"
                                                       IsNullable = false };
         Primitive { Type = Int
                     Name = "Revision"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "TableTarget"
                                                       IsNullable = false };
         Primitive { Type = String
                     Name = "Notes"
                     IsNullable = true }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "ConfigId"
      Type = Id Guid
      IsNullable = false }; { Name = "Description"
                              Type = Primitive String
                              IsNullable = false }; { Name = "Status"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "Owner"
      Type = Primitive String
      IsNullable = false }; { Name = "Timestamp"
                              Type = Primitive DateTime
                              IsNullable = false }; { Name = "RevisionGroup"
                                                      Type = Primitive Guid
                                                      IsNullable = false };
    { Name = "Revision"
      Type = Primitive Int
      IsNullable = false }; { Name = "TableTarget"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Notes"
                                                      Type = Primitive String
                                                      IsNullable = true };
    { Name = "NumberOfSequence"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "PilotMultiSequenceConfigDetail"
        TargetTable =
         { Name = TableName "PilotMultiSequenceConfigDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "ConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
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
        Destination = EntityName "PilotMultiSequenceConfigDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "PrmPilotMultiSequence"
        TargetTable =
         { Name = TableName "PrmPilotMultiSequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PilotTypeId0"
                         IsNullable = false };
             Primitive { Type = Guid
                         Name = "PilotParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId1"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "PilotTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "PilotParametersId3"
                         IsNullable = true };
             Primitive { Type = Guid
                         Name = "SequencesConfiguration"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId1Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "MultiSequencePilotType"
                          Name = "PilotTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PilotMultiSequenceConfig"
                          Name = "SequencesConfigurationNavigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmPilotMultiSequence"
        KeyType = Guid }] }-PrmPilotMultiSequence-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmPilotMultiSequences
                                    .Where(x => x.PrmPilotMultiSequence != null && ids.Contains((Guid)x.PrmPilotMultiSequence))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmPilotMultiSequence!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmPilotMultiSequences);
                    });
            
        }
    }
}
            
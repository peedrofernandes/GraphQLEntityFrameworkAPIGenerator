
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
    public partial class PrmPilotMultiSequenceGraphType : ObjectGraphType<PrmPilotMultiSequence>
    {
        public PrmPilotMultiSequenceGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PilotTypeId0, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PilotParametersId0, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotParametersId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotParametersId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.PilotTypeId3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.PilotParametersId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.SequencesConfiguration, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.NumOfPins, type: typeof(ByteGraphType), nullable: False);
            
                Field<MultiSequencePilotTypeGraphType, MultiSequencePilotType>("MultiSequencePilotTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiSequencePilotTypeGraphType>(
                            "{ Name = EntityName "PrmPilotMultiSequence"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmPilotMultiSequence"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PilotTypeId0"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "PilotParametersId0"
      Type = Primitive Guid
      IsNullable = true }; { Name = "PilotTypeId1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PilotParametersId1"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "PilotTypeId2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "PilotParametersId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "PilotTypeId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "PilotParametersId3"
      Type = Primitive Guid
      IsNullable = true }; { Name = "SequencesConfiguration"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "NumOfPins"
                                                    Type = Primitive Byte
                                                    IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "PilotTypeId0Navigation";
          RelationName "PilotTypeId1Navigation";
          RelationName "PilotTypeId2Navigation";
          RelationName "PilotTypeId3Navigation"]
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
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
        IsNullable = true
        KeyType = Guid }] }-MultiSequencePilotType-loader",
                            async ids => 
                            {
                                Expression<Func<MultiSequencePilotType, bool>> expr = x => !ids.Any()
                                    \|\| (x.PilotTypeId0Navigation != null && ids.Contains((byte)x.PilotTypeId0Navigation))
\|\| (x.PilotTypeId1Navigation != null && ids.Contains((byte)x.PilotTypeId1Navigation))
\|\| (x.PilotTypeId2Navigation != null && ids.Contains((byte)x.PilotTypeId2Navigation))
\|\| (x.PilotTypeId3Navigation != null && ids.Contains((byte)x.PilotTypeId3Navigation));

                                var data = await dbContext.MultiSequencePilotTypes
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.PilotTypeId0Navigation,
x.PilotTypeId1Navigation,
x.PilotTypeId2Navigation,
x.PilotTypeId3Navigation
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.MultiSequencePilotTypes);
                    });
            
			
                Field<PilotMultiSequenceConfigGraphType, PilotMultiSequenceConfig>("PilotMultiSequenceConfigs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, PilotMultiSequenceConfigGraphType>(
                            "{ Name = EntityName "PrmPilotMultiSequence"
  CorrespondingTable =
   Regular
     { Name = TableName "PrmPilotMultiSequence"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "Id"
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "Id"
      Type = Id Guid
      IsNullable = false }; { Name = "PilotTypeId0"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "PilotParametersId0"
      Type = Primitive Guid
      IsNullable = true }; { Name = "PilotTypeId1"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "PilotParametersId1"
                                                    Type = Primitive Guid
                                                    IsNullable = true };
    { Name = "PilotTypeId2"
      Type = Primitive Byte
      IsNullable = true }; { Name = "PilotParametersId2"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "PilotTypeId3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "PilotParametersId3"
      Type = Primitive Guid
      IsNullable = true }; { Name = "SequencesConfiguration"
                             Type = Primitive Guid
                             IsNullable = true }; { Name = "NumOfPins"
                                                    Type = Primitive Byte
                                                    IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "PilotTypeId0Navigation";
          RelationName "PilotTypeId1Navigation";
          RelationName "PilotTypeId2Navigation";
          RelationName "PilotTypeId3Navigation"]
        TargetTable =
         { Name = TableName "MultiSequencePilotType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "PilotTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "PilotType"
                          Name = "PilotType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmPilotMultiSequence"
                          Name = "PrmPilotMultiSequencePilotTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "MultiSequencePilotType"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
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
        IsNullable = true
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
            
        }
    }
}
            
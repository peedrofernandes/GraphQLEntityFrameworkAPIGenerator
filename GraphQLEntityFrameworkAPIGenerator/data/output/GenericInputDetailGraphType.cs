
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
    public partial class GenericInputDetailGraphType : ObjectGraphType<GenericInputDetail>
    {
        public GenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.GenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
            
                Field<GenericInputConfigurationsGenericInputDetailGraphType, GenericInputConfigurationsGenericInputDetail>("GenericInputConfigurationsGenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputConfigurationsGenericInputDetailGraphType>>(
                            "{ Name = EntityName "GenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "GenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "GenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "InputId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ReadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "ReadTypePos"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ParametersId"
                      IsNullable = true };
         Navigation
           { Type = TableName "GenericInputConfigurationsGenericInputDetail"
             Name = "GenericInputConfigurationsGenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Input"
                                                 Name = "Input"
                                                 IsNullable = false
                                                 IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "GenericInputDetailId"
              Type = Id Guid
              IsNullable = false }; { Name = "ReadTypePos"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputConfigurationsGenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputConfigurationsGenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfigurationsGenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Input"
        TargetTable =
         { Name = TableName "Input"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "InputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InputGroup"
                          Name = "InputGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Input"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ReadType"
        TargetTable =
         { Name = TableName "ReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "ReadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypeMax"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumPins"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Automatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Multiplexed"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Inverted"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Partialized"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Acline"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Vreference"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Compensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Delta"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Rotation"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PullUp"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Feedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "SecondFeedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MultiInputReadType"
                          Name = "MultiInputReadType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "UiinputsNavigation"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ReadType"
        IsNullable = false
        KeyType = Byte }] }-GenericInputConfigurationsGenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.GenericInputConfigurationsGenericInputDetails
                                    .Where(x => x.GenericInputConfigurationsGenericInputDetail != null && ids.Contains((Guid)x.GenericInputConfigurationsGenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.GenericInputConfigurationsGenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.GenericInputConfigurationsGenericInputDetails);
                    });
            
			
                Field<InputGraphType, Input>("Inputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputGraphType>(
                            "{ Name = EntityName "GenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "GenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "GenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "InputId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ReadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "ReadTypePos"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ParametersId"
                      IsNullable = true };
         Navigation
           { Type = TableName "GenericInputConfigurationsGenericInputDetail"
             Name = "GenericInputConfigurationsGenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Input"
                                                 Name = "Input"
                                                 IsNullable = false
                                                 IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "GenericInputDetailId"
              Type = Id Guid
              IsNullable = false }; { Name = "ReadTypePos"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputConfigurationsGenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputConfigurationsGenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfigurationsGenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Input"
        TargetTable =
         { Name = TableName "Input"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "InputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InputGroup"
                          Name = "InputGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Input"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ReadType"
        TargetTable =
         { Name = TableName "ReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "ReadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypeMax"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumPins"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Automatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Multiplexed"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Inverted"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Partialized"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Acline"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Vreference"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Compensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Delta"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Rotation"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PullUp"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Feedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "SecondFeedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MultiInputReadType"
                          Name = "MultiInputReadType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "UiinputsNavigation"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ReadType"
        IsNullable = false
        KeyType = Byte }] }-Input-loader",
                            async ids => 
                            {
                                var data = await dbContext.Inputs
                                    .Where(x => x.Input != null && ids.Contains((byte)x.Input))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Input!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Input);
                });
            
			
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "GenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "GenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "GenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "InputId"
                                                         IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "ReadTypeId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "ReadTypePos"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "ParametersId"
                      IsNullable = true };
         Navigation
           { Type = TableName "GenericInputConfigurationsGenericInputDetail"
             Name = "GenericInputConfigurationsGenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Input"
                                                 Name = "Input"
                                                 IsNullable = false
                                                 IsCollection = false };
         Navigation { Type = TableName "ReadType"
                      Name = "ReadType"
                      IsNullable = false
                      IsCollection = false }] }
  Fields = [{ Name = "GenericInputDetailId"
              Type = Id Guid
              IsNullable = false }; { Name = "ReadTypePos"
                                      Type = Primitive Byte
                                      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputConfigurationsGenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputConfigurationsGenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "GenericInputConfigurationsGenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Input"
        TargetTable =
         { Name = TableName "Input"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "InputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "InputGroup"
                          Name = "InputGroups"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Input"
        IsNullable = false
        KeyType = Byte };
    SingleManyToOne
      { Name = RelationName "ReadType"
        TargetTable =
         { Name = TableName "ReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "ReadTypeDsc"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "ReadTypeMax"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "NumPins"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NeedParams"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Automatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Multiplexed"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Inverted"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Partialized"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Acline"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Vreference"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Compensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Delta"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Rotation"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "PullUp"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "Feedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "SecondFeedback"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "GenericInputDetail"
                          Name = "GenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MultiInputReadType"
                          Name = "MultiInputReadType"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId0Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId1Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId2Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "PrmReadMultiInput"
                          Name = "PrmReadMultiInputReadTypeId3Navigations"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "UiinputsNavigation"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "ReadType"
        IsNullable = false
        KeyType = Byte }] }-ReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.ReadTypes
                                    .Where(x => x.ReadType != null && ids.Contains((byte)x.ReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.ReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.ReadType);
                });
            
        }
    }
}
            
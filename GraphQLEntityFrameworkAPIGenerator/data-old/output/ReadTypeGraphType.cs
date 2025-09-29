
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
    public partial class ReadTypeGraphType : ObjectGraphType<ReadType>
    {
        public ReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ReadTypeMax, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumPins, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Automatic, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.NumReadings, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Multiplexed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Inverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Partialized, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Acline, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Vreference, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Compensated, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Delta, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Feedback, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.SecondFeedback, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChannelDischarge, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
                Field<GenericInputDetailGraphType, GenericInputDetail>("GenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<GenericInputDetailGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-GenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.GenericInputDetails
                                    .Where(x => x.GenericInputDetail != null && ids.Contains((Guid)x.GenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.GenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.GenericInputDetails);
                    });
            
			
                Field<InputTypesReadTypeGraphType, InputTypesReadType>("InputTypesReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<InputTypesReadTypeGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-InputTypesReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.InputTypesReadTypes
                                    .Where(x => x.InputTypesReadType != null && ids.Contains((byte)x.InputTypesReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.InputTypesReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.InputTypesReadTypes);
                    });
            
			
                Field<LowLevelInputDetailGraphType, LowLevelInputDetail>("LowLevelInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputDetailGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-LowLevelInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LowLevelInputDetails
                                    .Where(x => x.LowLevelInputDetail != null && ids.Contains((Guid)x.LowLevelInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LowLevelInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.LowLevelInputDetails);
                    });
            
			
                Field<MultiInputReadTypeGraphType, MultiInputReadType>("MultiInputReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, MultiInputReadTypeGraphType>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-MultiInputReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.MultiInputReadTypes
                                    .Where(x => x.MultiInputReadType != null && ids.Contains((byte)x.MultiInputReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.MultiInputReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.MultiInputReadTypes);
                    });
            
			
                Field<PrmReadMultiInputGraphType, PrmReadMultiInput>("PrmReadMultiInputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<PrmReadMultiInputGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-PrmReadMultiInput-loader",
                            async ids => 
                            {
                                var data = await dbContext.PrmReadMultiInputs
                                    .Where(x => x.PrmReadMultiInput != null && ids.Contains((Guid)x.PrmReadMultiInput))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.PrmReadMultiInput!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.PrmReadMultiInputs);
                    });
            
			
                Field<UigenericInputDetailGraphType, UigenericInputDetail>("UigenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputDetailGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-UigenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputDetails
                                    .Where(x => x.UigenericInputDetail != null && ids.Contains((Guid)x.UigenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UigenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UigenericInputDetails);
                    });
            
			
                Field<UiinputGraphType, Uiinput>("Uiinputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, IEnumerable<UiinputGraphType>>(
                            "{ Name = EntityName "ReadType"
  CorrespondingTable =
   Regular
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "SecondFeedback"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "ChannelDischarge"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "ReadTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "ReadTypeMax"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "NumPins"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NeedParams"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Automatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "NumReadings"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Multiplexed"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Inverted"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Partialized"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Acline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Vreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Compensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Delta"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Rotation"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "PullUp"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Feedback"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "SecondFeedback"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "ChannelDischarge"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsSafetyRelevant"
                              Type = Primitive Bool
                              IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "GenericInputDetail"
        TargetTable =
         { Name = TableName "GenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "GenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
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
        Destination = EntityName "GenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "InputTypesReadType"
        TargetTable =
         { Name = TableName "InputTypesReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Navigation { Type = TableName "InputType"
                          Name = "InputType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "InputTypesReadType"
        KeyType = Byte };
    OneToMany
      { Name = RelationName "LowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypePos"
                                                            IsNullable = false };
             Primitive { Type = Byte
                         Name = "Delta"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "ChipSelect"
                                                           IsNullable = false };
             Primitive { Type = Byte
                         Name = "NumReadings"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAutomatic"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsMultiplexed"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsAcline"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsVreference"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsCompensated"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "IsInverted"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsPartialized"
                         IsNullable = false }; Primitive { Type = Bool
                                                           Name = "Rotation"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "PullUp"
                         IsNullable = false };
             Primitive { Type = Bool
                         Name = "ChannelDischarge"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Pin1"
                                                           IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "Pin3"
                                                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "Pin4"
                         IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ReadParametersId"
                          IsNullable = true };
             Navigation
               { Type =
                  TableName "LowLevelInputConfigurationsLowLevelInputDetail"
                 Name = "LowLevelInputConfigurationsLowLevelInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                     Name = "ReadType"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "LowLevelInputDetail"
        KeyType = Guid };
    OneToOne
      { Name = RelationName "MultiInputReadType"
        TargetTable =
         { Name = TableName "MultiInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "ReadTypeId"
                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadType"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "MultiInputReadType"
        IsNullable = true
        KeyType = Byte };
    OneToMany
      { Name = RelationName "PrmReadMultiInput"
        TargetTable =
         { Name = TableName "PrmReadMultiInput"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "ReadTypeId0"
                                                            IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId0"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId1"
                                                          IsNullable = false };
             Primitive { Type = Guid
                         Name = "ReadParametersId1"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId2"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId2"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "ReadTypeId3"
                                                          IsNullable = true };
             Primitive { Type = Guid
                         Name = "ReadParametersId3"
                         IsNullable = true }; Primitive { Type = Byte
                                                          Name = "NumOfPins"
                                                          IsNullable = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId0Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId1Navigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId2Navigation"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypeId3Navigation"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "PrmReadMultiInput"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "LlireadTypePosition"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "ParametersId"
                          IsNullable = true };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation
               { Type =
                  TableName "UigenericInputConfigurationsUigenericInputDetail"
                 Name = "UigenericInputConfigurationsUigenericInputDetails"
                 IsNullable = false
                 IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                     Name = "Uiinput"
                                                     IsNullable = false
                                                     IsCollection = false }] }
        Destination = EntityName "UigenericInputDetail"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Uiinput"
        TargetTable =
         { Name = TableName "Uiinput"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UiinputId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "UiinputDsc"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "LlireadTypeId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "NeedParams"
                                                            IsNullable = false };
             Primitive { Type = Bool
                         Name = "IsSafetyRelevant"
                         IsNullable = false };
             Navigation { Type = TableName "UigenericInputReadType"
                          Name = "GireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "ReadType"
                          Name = "LlireadType"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "ReadType"
                          Name = "ReadTypes"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uiinput"
        KeyType = Byte }] }-Uiinput-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uiinputs
                                    .Where(x => x.Uiinput != null && ids.Contains((byte)x.Uiinput))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Uiinput!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Uiinputs);
                    });
            
        }
    }
}
            
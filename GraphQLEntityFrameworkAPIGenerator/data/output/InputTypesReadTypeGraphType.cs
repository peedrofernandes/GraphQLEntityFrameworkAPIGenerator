
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
    public partial class InputTypesReadTypeGraphType : ObjectGraphType<InputTypesReadType>
    {
        public InputTypesReadTypeGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.InputTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ReadTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
            
                Field<InputTypeGraphType, InputType>("InputTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, InputTypeGraphType>(
                            "{ Name = EntityName "InputTypesReadType"
  CorrespondingTable =
   Regular
     { Name = TableName "InputTypesReadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "InputTypeId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "ReadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Bool
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
  Fields =
   [{ Name = "InputTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeId"
                              Type = Id Byte
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InputType"
        TargetTable =
         { Name = TableName "InputType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "InputTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Input"
                          Name = "Inputs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InputType"
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
        KeyType = Byte }] }-InputType-loader",
                            async ids => 
                            {
                                var data = await dbContext.InputTypes
                                    .Where(x => x.InputType != null && ids.Contains((byte)x.InputType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.InputType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.InputType);
                });
            
			
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "InputTypesReadType"
  CorrespondingTable =
   Regular
     { Name = TableName "InputTypesReadType"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "InputTypeId"
                      IsNullable = false }; PrimaryKey { Type = Byte
                                                         Name = "ReadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Bool
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
  Fields =
   [{ Name = "InputTypeId"
      Type = Id Byte
      IsNullable = false }; { Name = "ReadTypeId"
                              Type = Id Byte
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "InputType"
        TargetTable =
         { Name = TableName "InputType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "InputTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "InputTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "InputTypesReadType"
                          Name = "InputTypesReadTypes"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Input"
                          Name = "Inputs"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "InputType"
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
            
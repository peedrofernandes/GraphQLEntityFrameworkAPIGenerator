
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
    public partial class UiinputGraphType : ObjectGraphType<Uiinput>
    {
        public UiinputGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UiinputId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.UiinputDsc, type: typeof(StringGraphType), nullable: False);
			Field(t => t.NeedParams, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsSafetyRelevant, type: typeof(BoolGraphType), nullable: False);
            
                Field<UigenericInputReadTypeGraphType, UigenericInputReadType>("UigenericInputReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UigenericInputReadTypeGraphType>(
                            "{ Name = EntityName "Uiinput"
  CorrespondingTable =
   Regular
     { Name = TableName "Uiinput"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UiinputId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "UiinputDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LlireadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedParams"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "UiinputId"
      Type = Id Byte
      IsNullable = false }; { Name = "UiinputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputReadType"
        TargetTable =
         { Name = TableName "UigenericInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UireadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UireadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventDetail"
                          Name = "UisreventDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UigenericInputReadType"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names = [RelationName "LlireadType"; RelationName "ReadTypes"]
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
        KeyType = Byte };
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
        KeyType = Guid }] }-UigenericInputReadType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputReadTypes
                                    .Where(x => x.UigenericInputReadType != null && ids.Contains((byte)x.UigenericInputReadType))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.UigenericInputReadType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UigenericInputReadType);
                });
            
			
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "Uiinput"
  CorrespondingTable =
   Regular
     { Name = TableName "Uiinput"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UiinputId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "UiinputDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LlireadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedParams"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "UiinputId"
      Type = Id Byte
      IsNullable = false }; { Name = "UiinputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputReadType"
        TargetTable =
         { Name = TableName "UigenericInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UireadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UireadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventDetail"
                          Name = "UisreventDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UigenericInputReadType"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names = [RelationName "LlireadType"; RelationName "ReadTypes"]
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
        KeyType = Byte };
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
        KeyType = Guid }] }-ReadType-loader",
                            async ids => 
                            {
                                Expression<Func<ReadType, bool>> expr = x => !ids.Any()
                                    \|\| (x.LlireadType != null && ids.Contains((byte)x.LlireadType))
\|\| (x.ReadTypes != null && ids.Contains((byte)x.ReadTypes));

                                var data = await dbContext.ReadTypes
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.LlireadType,
x.ReadTypes
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.ReadTypes);
                    });
            
			
                Field<UigenericInputDetailGraphType, UigenericInputDetail>("UigenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputDetailGraphType>>(
                            "{ Name = EntityName "Uiinput"
  CorrespondingTable =
   Regular
     { Name = TableName "Uiinput"
       Properties =
        [PrimaryKey { Type = Byte
                      Name = "UiinputId"
                      IsNullable = false }; Primitive { Type = String
                                                        Name = "UiinputDsc"
                                                        IsNullable = false };
         ForeignKey { Type = Byte
                      Name = "GireadTypeId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "LlireadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Bool
                     Name = "NeedParams"
                     IsNullable = false }; Primitive { Type = Bool
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
  Fields =
   [{ Name = "UiinputId"
      Type = Id Byte
      IsNullable = false }; { Name = "UiinputDsc"
                              Type = Primitive String
                              IsNullable = false }; { Name = "NeedParams"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsSafetyRelevant"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UigenericInputReadType"
        TargetTable =
         { Name = TableName "UigenericInputReadType"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "UireadTypeId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "UireadTypeDsc"
                         IsNullable = false };
             Navigation { Type = TableName "UiclassBeventDetail"
                          Name = "UiclassBeventDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Uiinput"
                          Name = "Uiinputs"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisreventDetail"
                          Name = "UisreventDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UigenericInputReadType"
        IsNullable = false
        KeyType = Byte };
    MultipleManyToOne
      { Names = [RelationName "LlireadType"; RelationName "ReadTypes"]
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
        KeyType = Byte };
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
        KeyType = Guid }] }-UigenericInputDetail-loader",
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
            
        }
    }
}
            
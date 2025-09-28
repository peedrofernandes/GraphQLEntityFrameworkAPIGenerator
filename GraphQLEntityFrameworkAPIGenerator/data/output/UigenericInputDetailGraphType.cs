
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
    public partial class UigenericInputDetailGraphType : ObjectGraphType<UigenericInputDetail>
    {
        public UigenericInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UigenericInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.GireadTypePosition, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.LlireadTypePosition, type: typeof(ByteGraphType), nullable: False);
            
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "UigenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UigenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "ParametersId"
                                                        IsNullable = true };
         Navigation { Type = TableName "ReadType"
                      Name = "LlireadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "UigenericInputConfigurationsUigenericInputDetail"
             Name = "UigenericInputConfigurationsUigenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                 Name = "Uiinput"
                                                 IsNullable = false
                                                 IsCollection = false }] }
  Fields =
   [{ Name = "UigenericInputDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "GireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "LlireadTypePosition"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UigenericInputConfigurationsUigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputConfigurationsUigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UigenericInputConfigurationsUigenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
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
            
			
                Field<UigenericInputConfigurationsUigenericInputDetailGraphType, UigenericInputConfigurationsUigenericInputDetail>("UigenericInputConfigurationsUigenericInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UigenericInputConfigurationsUigenericInputDetailGraphType>>(
                            "{ Name = EntityName "UigenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UigenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "ParametersId"
                                                        IsNullable = true };
         Navigation { Type = TableName "ReadType"
                      Name = "LlireadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "UigenericInputConfigurationsUigenericInputDetail"
             Name = "UigenericInputConfigurationsUigenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                 Name = "Uiinput"
                                                 IsNullable = false
                                                 IsCollection = false }] }
  Fields =
   [{ Name = "UigenericInputDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "GireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "LlireadTypePosition"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UigenericInputConfigurationsUigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputConfigurationsUigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UigenericInputConfigurationsUigenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Byte }] }-UigenericInputConfigurationsUigenericInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UigenericInputConfigurationsUigenericInputDetails
                                    .Where(x => x.UigenericInputConfigurationsUigenericInputDetail != null && ids.Contains((Guid)x.UigenericInputConfigurationsUigenericInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UigenericInputConfigurationsUigenericInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UigenericInputConfigurationsUigenericInputDetails);
                    });
            
			
                Field<UiinputGraphType, Uiinput>("Uiinputs")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, UiinputGraphType>(
                            "{ Name = EntityName "UigenericInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UigenericInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UigenericInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
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
                     IsNullable = false }; ForeignKey { Type = Guid
                                                        Name = "ParametersId"
                                                        IsNullable = true };
         Navigation { Type = TableName "ReadType"
                      Name = "LlireadType"
                      IsNullable = false
                      IsCollection = false };
         Navigation
           { Type = TableName "UigenericInputConfigurationsUigenericInputDetail"
             Name = "UigenericInputConfigurationsUigenericInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "Uiinput"
                                                 Name = "Uiinput"
                                                 IsNullable = false
                                                 IsCollection = false }] }
  Fields =
   [{ Name = "UigenericInputDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "GireadTypePosition"
                              Type = Primitive Byte
                              IsNullable = false };
    { Name = "LlireadTypePosition"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
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
        KeyType = Byte };
    OneToMany
      { Name = RelationName "UigenericInputConfigurationsUigenericInputDetail"
        TargetTable =
         { Name = TableName "UigenericInputConfigurationsUigenericInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UigenericInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UigenericInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UigenericInputConfiguration"
                          Name = "UigenericInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UigenericInputDetail"
                          Name = "UigenericInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UigenericInputConfigurationsUigenericInputDetail"
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uiinput);
                });
            
        }
    }
}
            
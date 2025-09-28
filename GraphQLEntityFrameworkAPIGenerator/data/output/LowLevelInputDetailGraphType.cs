
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
    public partial class LowLevelInputDetailGraphType : ObjectGraphType<LowLevelInputDetail>
    {
        public LowLevelInputDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.LowLevelInputDetailId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.ReadTypePos, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Delta, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.ChipSelect, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.NumReadings, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.IsAutomatic, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsMultiplexed, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsAcline, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsVreference, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsCompensated, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsInverted, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.IsPartialized, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rotation, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.PullUp, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ChannelDischarge, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Pin1, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin2, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin3, type: typeof(ByteGraphType), nullable: True);
			Field(t => t.Pin4, type: typeof(ByteGraphType), nullable: True);
            
                Field<LowLevelInputConfigurationsLowLevelInputDetailGraphType, LowLevelInputConfigurationsLowLevelInputDetail>("LowLevelInputConfigurationsLowLevelInputDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<LowLevelInputConfigurationsLowLevelInputDetailGraphType>>(
                            "{ Name = EntityName "LowLevelInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LowLevelInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LowLevelInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ReadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "ReadTypePos"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Delta"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ChipSelect"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumReadings"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsAutomatic"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "IsMultiplexed"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsAcline"
                     IsNullable = false }; Primitive { Type = Bool
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "ChannelDischarge"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Pin1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Pin2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "Pin3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Pin4"
                                                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ReadParametersId"
                      IsNullable = true };
         Navigation
           { Type = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
             Name = "LowLevelInputConfigurationsLowLevelInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                 Name = "ReadType"
                                                 IsNullable = false
                                                 IsCollection = false }] }
  Fields =
   [{ Name = "LowLevelInputDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "ReadTypePos"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Delta"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ChipSelect"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumReadings"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "IsAutomatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsMultiplexed"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsAcline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsVreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsCompensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsInverted"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsPartialized"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Rotation"
      Type = Primitive Bool
      IsNullable = false }; { Name = "PullUp"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "ChannelDischarge"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Pin1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Pin3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "Pin4"
      Type = Primitive Byte
      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "LowLevelInputConfigurationsLowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "LowLevelInputConfigurationsLowLevelInputDetail"
        KeyType = Guid };
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
        KeyType = Byte }] }-LowLevelInputConfigurationsLowLevelInputDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.LowLevelInputConfigurationsLowLevelInputDetails
                                    .Where(x => x.LowLevelInputConfigurationsLowLevelInputDetail != null && ids.Contains((Guid)x.LowLevelInputConfigurationsLowLevelInputDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.LowLevelInputConfigurationsLowLevelInputDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.LowLevelInputConfigurationsLowLevelInputDetails);
                    });
            
			
                Field<ReadTypeGraphType, ReadType>("ReadTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, ReadTypeGraphType>(
                            "{ Name = EntityName "LowLevelInputDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "LowLevelInputDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "LowLevelInputDetailId"
                      IsNullable = false }; ForeignKey { Type = Byte
                                                         Name = "ReadTypeId"
                                                         IsNullable = false };
         Primitive { Type = Byte
                     Name = "ReadTypePos"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Delta"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "ChipSelect"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "NumReadings"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsAutomatic"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "IsMultiplexed"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "IsAcline"
                     IsNullable = false }; Primitive { Type = Bool
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
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "ChannelDischarge"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Pin1"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Pin2"
                                                      IsNullable = true };
         Primitive { Type = Byte
                     Name = "Pin3"
                     IsNullable = true }; Primitive { Type = Byte
                                                      Name = "Pin4"
                                                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "ReadParametersId"
                      IsNullable = true };
         Navigation
           { Type = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
             Name = "LowLevelInputConfigurationsLowLevelInputDetails"
             IsNullable = false
             IsCollection = true }; Navigation { Type = TableName "ReadType"
                                                 Name = "ReadType"
                                                 IsNullable = false
                                                 IsCollection = false }] }
  Fields =
   [{ Name = "LowLevelInputDetailId"
      Type = Id Guid
      IsNullable = false }; { Name = "ReadTypePos"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Delta"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "ChipSelect"
      Type = Primitive Byte
      IsNullable = false }; { Name = "NumReadings"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "IsAutomatic"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsMultiplexed"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsAcline"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsVreference"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "IsCompensated"
      Type = Primitive Bool
      IsNullable = false }; { Name = "IsInverted"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "IsPartialized"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Rotation"
      Type = Primitive Bool
      IsNullable = false }; { Name = "PullUp"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "ChannelDischarge"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Pin1"
      Type = Primitive Byte
      IsNullable = true }; { Name = "Pin2"
                             Type = Primitive Byte
                             IsNullable = true }; { Name = "Pin3"
                                                    Type = Primitive Byte
                                                    IsNullable = true };
    { Name = "Pin4"
      Type = Primitive Byte
      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "LowLevelInputConfigurationsLowLevelInputDetail"
        TargetTable =
         { Name = TableName "LowLevelInputConfigurationsLowLevelInputDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "LowLevelInputDetailId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "LowLevelInputDetail"
                          Name = "LowLevelInputDetail"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "LowLevelInputConfigurationsLowLevelInputDetail"
        KeyType = Guid };
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
            
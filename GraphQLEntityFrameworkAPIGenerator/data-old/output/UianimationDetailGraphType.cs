
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
    public partial class UianimationDetailGraphType : ObjectGraphType<UianimationDetail>
    {
        public UianimationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.AnimationType, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PatternExecutions, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Csf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Iaf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Tsf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Cef, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Df, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Rf, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Period, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.TimeBetweenRepeats, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.AnimationFunction, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.Compartment, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AnimationIndex, type: typeof(ByteGraphType), nullable: False);
            
                Field<UianimationBlinkTypeGraphType, UianimationBlinkType>("UianimationBlinkTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationBlinkTypeGraphType>(
                            "{ Name = EntityName "UianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
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
                                                      Name = "AnimationType"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PatternExecutions"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Csf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Iaf"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Tsf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Cef"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Df"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Rf"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "Period"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeBetweenRepeats"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UianimationFadingTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationBlinkTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationSequenceTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationFrameTypeId"
                      IsNullable = true };
         Primitive { Type = Short
                     Name = "AnimationFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AnimationIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UianimationBlinkType"
                      Name = "UianimationBlinkType"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type = TableName "UianimationConfigurationsUianimationDetail"
             Name = "UianimationConfigurationsUianimationDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "UianimationFadingType"
                      Name = "UianimationFadingType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationSequenceType"
                      Name = "UianimationSequenceType"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationDetailsId"
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
    { Name = "AnimationType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PatternExecutions"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Csf"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Iaf"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Tsf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Cef"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Df"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Rf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Period"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeBetweenRepeats"
      Type = Primitive Short
      IsNullable = false }; { Name = "AnimationFunction"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "AnimationIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationBlinkType"
        TargetTable =
         { Name = TableName "UianimationBlinkType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "DutyCycle"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationBlinkType"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UianimationConfigurationsUianimationDetail"
        TargetTable =
         { Name = TableName "UianimationConfigurationsUianimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UianimationConfigurationsUianimationDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFadingType"
        TargetTable =
         { Name = TableName "UianimationFadingType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "InitialIntensity"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FinalIntensity"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationFadingType"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationSequenceType"
        TargetTable =
         { Name = TableName "UianimationSequenceType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "StepNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailScalingNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailStepNumber"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationSequenceType"
        IsNullable = true
        KeyType = Guid }] }-UianimationBlinkType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationBlinkTypes
                                    .Where(x => x.UianimationBlinkType != null && ids.Contains((Guid)x.UianimationBlinkType))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationBlinkType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationBlinkType);
                });
            
			
                Field<UianimationConfigurationsUianimationDetailGraphType, UianimationConfigurationsUianimationDetail>("UianimationConfigurationsUianimationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationConfigurationsUianimationDetailGraphType>>(
                            "{ Name = EntityName "UianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
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
                                                      Name = "AnimationType"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PatternExecutions"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Csf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Iaf"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Tsf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Cef"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Df"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Rf"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "Period"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeBetweenRepeats"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UianimationFadingTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationBlinkTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationSequenceTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationFrameTypeId"
                      IsNullable = true };
         Primitive { Type = Short
                     Name = "AnimationFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AnimationIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UianimationBlinkType"
                      Name = "UianimationBlinkType"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type = TableName "UianimationConfigurationsUianimationDetail"
             Name = "UianimationConfigurationsUianimationDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "UianimationFadingType"
                      Name = "UianimationFadingType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationSequenceType"
                      Name = "UianimationSequenceType"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationDetailsId"
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
    { Name = "AnimationType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PatternExecutions"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Csf"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Iaf"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Tsf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Cef"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Df"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Rf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Period"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeBetweenRepeats"
      Type = Primitive Short
      IsNullable = false }; { Name = "AnimationFunction"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "AnimationIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationBlinkType"
        TargetTable =
         { Name = TableName "UianimationBlinkType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "DutyCycle"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationBlinkType"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UianimationConfigurationsUianimationDetail"
        TargetTable =
         { Name = TableName "UianimationConfigurationsUianimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UianimationConfigurationsUianimationDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFadingType"
        TargetTable =
         { Name = TableName "UianimationFadingType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "InitialIntensity"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FinalIntensity"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationFadingType"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationSequenceType"
        TargetTable =
         { Name = TableName "UianimationSequenceType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "StepNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailScalingNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailStepNumber"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationSequenceType"
        IsNullable = true
        KeyType = Guid }] }-UianimationConfigurationsUianimationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationConfigurationsUianimationDetails
                                    .Where(x => x.UianimationConfigurationsUianimationDetail != null && ids.Contains((Guid)x.UianimationConfigurationsUianimationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationConfigurationsUianimationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UianimationConfigurationsUianimationDetails);
                    });
            
			
                Field<UianimationFadingTypeGraphType, UianimationFadingType>("UianimationFadingTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFadingTypeGraphType>(
                            "{ Name = EntityName "UianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
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
                                                      Name = "AnimationType"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PatternExecutions"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Csf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Iaf"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Tsf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Cef"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Df"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Rf"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "Period"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeBetweenRepeats"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UianimationFadingTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationBlinkTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationSequenceTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationFrameTypeId"
                      IsNullable = true };
         Primitive { Type = Short
                     Name = "AnimationFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AnimationIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UianimationBlinkType"
                      Name = "UianimationBlinkType"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type = TableName "UianimationConfigurationsUianimationDetail"
             Name = "UianimationConfigurationsUianimationDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "UianimationFadingType"
                      Name = "UianimationFadingType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationSequenceType"
                      Name = "UianimationSequenceType"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationDetailsId"
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
    { Name = "AnimationType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PatternExecutions"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Csf"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Iaf"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Tsf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Cef"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Df"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Rf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Period"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeBetweenRepeats"
      Type = Primitive Short
      IsNullable = false }; { Name = "AnimationFunction"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "AnimationIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationBlinkType"
        TargetTable =
         { Name = TableName "UianimationBlinkType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "DutyCycle"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationBlinkType"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UianimationConfigurationsUianimationDetail"
        TargetTable =
         { Name = TableName "UianimationConfigurationsUianimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UianimationConfigurationsUianimationDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFadingType"
        TargetTable =
         { Name = TableName "UianimationFadingType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "InitialIntensity"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FinalIntensity"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationFadingType"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationSequenceType"
        TargetTable =
         { Name = TableName "UianimationSequenceType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "StepNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailScalingNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailStepNumber"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationSequenceType"
        IsNullable = true
        KeyType = Guid }] }-UianimationFadingType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFadingTypes
                                    .Where(x => x.UianimationFadingType != null && ids.Contains((Guid)x.UianimationFadingType))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFadingType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationFadingType);
                });
            
			
                Field<UianimationFrameConfigurationGraphType, UianimationFrameConfiguration>("UianimationFrameConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationFrameConfigurationGraphType>(
                            "{ Name = EntityName "UianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
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
                                                      Name = "AnimationType"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PatternExecutions"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Csf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Iaf"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Tsf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Cef"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Df"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Rf"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "Period"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeBetweenRepeats"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UianimationFadingTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationBlinkTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationSequenceTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationFrameTypeId"
                      IsNullable = true };
         Primitive { Type = Short
                     Name = "AnimationFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AnimationIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UianimationBlinkType"
                      Name = "UianimationBlinkType"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type = TableName "UianimationConfigurationsUianimationDetail"
             Name = "UianimationConfigurationsUianimationDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "UianimationFadingType"
                      Name = "UianimationFadingType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationSequenceType"
                      Name = "UianimationSequenceType"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationDetailsId"
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
    { Name = "AnimationType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PatternExecutions"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Csf"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Iaf"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Tsf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Cef"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Df"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Rf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Period"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeBetweenRepeats"
      Type = Primitive Short
      IsNullable = false }; { Name = "AnimationFunction"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "AnimationIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationBlinkType"
        TargetTable =
         { Name = TableName "UianimationBlinkType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "DutyCycle"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationBlinkType"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UianimationConfigurationsUianimationDetail"
        TargetTable =
         { Name = TableName "UianimationConfigurationsUianimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UianimationConfigurationsUianimationDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFadingType"
        TargetTable =
         { Name = TableName "UianimationFadingType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "InitialIntensity"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FinalIntensity"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationFadingType"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationSequenceType"
        TargetTable =
         { Name = TableName "UianimationSequenceType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "StepNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailScalingNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailStepNumber"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationSequenceType"
        IsNullable = true
        KeyType = Guid }] }-UianimationFrameConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFrameConfigurations
                                    .Where(x => x.UianimationFrameConfiguration != null && ids.Contains((Guid)x.UianimationFrameConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFrameConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationFrameConfiguration);
                });
            
			
                Field<UianimationSequenceTypeGraphType, UianimationSequenceType>("UianimationSequenceTypes")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationSequenceTypeGraphType>(
                            "{ Name = EntityName "UianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
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
                                                      Name = "AnimationType"
                                                      IsNullable = false };
         Primitive { Type = Byte
                     Name = "PatternExecutions"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Csf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Iaf"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Tsf"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Cef"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "Df"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "Rf"
                     IsNullable = false }; Primitive { Type = Short
                                                       Name = "Period"
                                                       IsNullable = false };
         Primitive { Type = Short
                     Name = "TimeBetweenRepeats"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "UianimationFadingTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationBlinkTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationSequenceTypeId"
                      IsNullable = true };
         ForeignKey { Type = Guid
                      Name = "UianimationFrameTypeId"
                      IsNullable = true };
         Primitive { Type = Short
                     Name = "AnimationFunction"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "Compartment"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "AnimationIndex"
                     IsNullable = false };
         Navigation { Type = TableName "UianimationBlinkType"
                      Name = "UianimationBlinkType"
                      IsNullable = true
                      IsCollection = false };
         Navigation
           { Type = TableName "UianimationConfigurationsUianimationDetail"
             Name = "UianimationConfigurationsUianimationDetails"
             IsNullable = false
             IsCollection = true };
         Navigation { Type = TableName "UianimationFadingType"
                      Name = "UianimationFadingType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationFrameConfiguration"
                      Name = "UianimationFrameType"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "UianimationSequenceType"
                      Name = "UianimationSequenceType"
                      IsNullable = true
                      IsCollection = false }] }
  Fields =
   [{ Name = "UianimationDetailsId"
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
    { Name = "AnimationType"
      Type = Primitive Byte
      IsNullable = false }; { Name = "PatternExecutions"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "Csf"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Iaf"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Tsf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Cef"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Df"
      Type = Primitive Bool
      IsNullable = false }; { Name = "Rf"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "Period"
                                                      Type = Primitive Short
                                                      IsNullable = false };
    { Name = "TimeBetweenRepeats"
      Type = Primitive Short
      IsNullable = false }; { Name = "AnimationFunction"
                              Type = Primitive Short
                              IsNullable = false }; { Name = "Compartment"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "AnimationIndex"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationBlinkType"
        TargetTable =
         { Name = TableName "UianimationBlinkType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "DutyCycle"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationBlinkType"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "UianimationConfigurationsUianimationDetail"
        TargetTable =
         { Name = TableName "UianimationConfigurationsUianimationDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationConfiguration"
                          Name = "UianimationConfiguration"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "UianimationConfigurationsUianimationDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFadingType"
        TargetTable =
         { Name = TableName "UianimationFadingType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "InitialIntensity"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "FinalIntensity"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationFadingType"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationFrameConfiguration"
        TargetTable =
         { Name = TableName "UianimationFrameConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
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
                         Name = "NumOfFrames"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type =
                  TableName
                    "UianimationFrameConfigurationsUianimationFrameDetail"
                 Name = "UianimationFrameConfigurationsUianimationFrameDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationFrameConfiguration"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UianimationSequenceType"
        TargetTable =
         { Name = TableName "UianimationSequenceType"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "Id"
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
                         Name = "StepNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailScalingNumber"
                         IsNullable = false };
             Primitive { Type = Byte
                         Name = "TailStepNumber"
                         IsNullable = false };
             Navigation { Type = TableName "UianimationDetail"
                          Name = "UianimationDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UianimationSequenceType"
        IsNullable = true
        KeyType = Guid }] }-UianimationSequenceType-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationSequenceTypes
                                    .Where(x => x.UianimationSequenceType != null && ids.Contains((Guid)x.UianimationSequenceType))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationSequenceType!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationSequenceType);
                });
            
        }
    }
}
            
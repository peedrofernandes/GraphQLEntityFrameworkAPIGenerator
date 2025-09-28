
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
    public partial class UianimationFrameConfigurationGraphType : ObjectGraphType<UianimationFrameConfiguration>
    {
        public UianimationFrameConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationFrameConfigurationsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.NumOfFrames, type: typeof(ByteGraphType), nullable: False);
            
                Field<UianimationDetailGraphType, UianimationDetail>("UianimationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationDetailGraphType>>(
                            "{ Name = EntityName "UianimationFrameConfiguration"
  CorrespondingTable =
   Regular
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
                                                      Name = "NumOfFrames"
                                                      IsNullable = false };
         Navigation { Type = TableName "UianimationDetail"
                      Name = "UianimationDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName "UianimationFrameConfigurationsUianimationFrameDetail"
             Name = "UianimationFrameConfigurationsUianimationFrameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UianimationFrameConfigurationsId"
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
    { Name = "NumOfFrames"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UianimationDetail"
        TargetTable =
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
        Destination = EntityName "UianimationDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "UianimationFrameConfigurationsUianimationFrameDetail"
        TargetTable =
         { Name =
            TableName "UianimationFrameConfigurationsUianimationFrameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationFrameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationFrameConfiguration"
                          Name = "UianimationFrameConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationFrameDetail"
                          Name = "UianimationFrameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UianimationFrameConfigurationsUianimationFrameDetail"
        KeyType = Guid }] }-UianimationDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationDetails
                                    .Where(x => x.UianimationDetail != null && ids.Contains((Guid)x.UianimationDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UianimationDetails);
                    });
            
			
                Field<UianimationFrameConfigurationsUianimationFrameDetailGraphType, UianimationFrameConfigurationsUianimationFrameDetail>("UianimationFrameConfigurationsUianimationFrameDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<UianimationFrameConfigurationsUianimationFrameDetailGraphType>>(
                            "{ Name = EntityName "UianimationFrameConfiguration"
  CorrespondingTable =
   Regular
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
                                                      Name = "NumOfFrames"
                                                      IsNullable = false };
         Navigation { Type = TableName "UianimationDetail"
                      Name = "UianimationDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation
           { Type =
              TableName "UianimationFrameConfigurationsUianimationFrameDetail"
             Name = "UianimationFrameConfigurationsUianimationFrameDetails"
             IsNullable = false
             IsCollection = true }] }
  Fields =
   [{ Name = "UianimationFrameConfigurationsId"
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
    { Name = "NumOfFrames"
      Type = Primitive Byte
      IsNullable = false }]
  Relations =
   [OneToMany
      { Name = RelationName "UianimationDetail"
        TargetTable =
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
        Destination = EntityName "UianimationDetail"
        KeyType = Guid };
    OneToMany
      { Name =
         RelationName "UianimationFrameConfigurationsUianimationFrameDetail"
        TargetTable =
         { Name =
            TableName "UianimationFrameConfigurationsUianimationFrameDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationFrameConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "UianimationFrameDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             Navigation { Type = TableName "UianimationFrameConfiguration"
                          Name = "UianimationFrameConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UianimationFrameDetail"
                          Name = "UianimationFrameDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination =
         EntityName "UianimationFrameConfigurationsUianimationFrameDetail"
        KeyType = Guid }] }-UianimationFrameConfigurationsUianimationFrameDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationFrameConfigurationsUianimationFrameDetails
                                    .Where(x => x.UianimationFrameConfigurationsUianimationFrameDetail != null && ids.Contains((Guid)x.UianimationFrameConfigurationsUianimationFrameDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationFrameConfigurationsUianimationFrameDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.UianimationFrameConfigurationsUianimationFrameDetails);
                    });
            
        }
    }
}
            
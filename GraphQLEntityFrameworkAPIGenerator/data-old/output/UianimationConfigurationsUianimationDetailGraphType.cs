
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
    public partial class UianimationConfigurationsUianimationDetailGraphType : ObjectGraphType<UianimationConfigurationsUianimationDetail>
    {
        public UianimationConfigurationsUianimationDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UianimationConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UianimationDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UianimationConfigurationGraphType, UianimationConfiguration>("UianimationConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationConfigurationGraphType>(
                            "{ Name = EntityName "UianimationConfigurationsUianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationConfigurationsUianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UianimationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UianimationDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationConfiguration"
        TargetTable =
         { Name = TableName "UianimationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "UianimationConfigurationsUianimationDetail"
                 Name = "UianimationConfigurationsUianimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
        KeyType = Guid }] }-UianimationConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UianimationConfigurations
                                    .Where(x => x.UianimationConfiguration != null && ids.Contains((Guid)x.UianimationConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UianimationConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationConfiguration);
                });
            
			
                Field<UianimationDetailGraphType, UianimationDetail>("UianimationDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UianimationDetailGraphType>(
                            "{ Name = EntityName "UianimationConfigurationsUianimationDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "UianimationConfigurationsUianimationDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UianimationConfigurationId"
                      IsNullable = false };
         PrimaryKey { Type = Guid
                      Name = "UianimationDetailsId"
                      IsNullable = false }; PrimaryKey { Type = Byte
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
  Fields =
   [{ Name = "UianimationConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UianimationDetailsId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "UianimationConfiguration"
        TargetTable =
         { Name = TableName "UianimationConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UianimationConfigurationId"
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
             Navigation { Type = TableName "Display"
                          Name = "Displays"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "UianimationConfigurationsUianimationDetail"
                 Name = "UianimationConfigurationsUianimationDetails"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "UianimationConfiguration"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
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
        IsNullable = false
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

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UianimationDetail);
                });
            
        }
    }
}
            
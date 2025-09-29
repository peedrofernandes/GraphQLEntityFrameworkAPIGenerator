
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
    public partial class UisequenceConfigurationsUisequenceGraphType : ObjectGraphType<UisequenceConfigurationsUisequence>
    {
        public UisequenceConfigurationsUisequenceGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.UisequenceConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.UisequenceId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<UiconditionGraphType, Uicondition>("Uiconditions")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UiconditionGraphType>(
                            "{ Name = EntityName "UisequenceConfigurationsUisequence"
  CorrespondingTable =
   Regular
     { Name = TableName "UisequenceConfigurationsUisequence"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisequenceConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UisequenceId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "UiconditionId"
                                                         IsNullable = true };
         Navigation { Type = TableName "Uicondition"
                      Name = "Uicondition"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uisequence"
                      Name = "Uisequence"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisequenceConfiguration"
                      Name = "UisequenceConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UisequenceConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UisequenceId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uicondition"
        TargetTable =
         { Name = TableName "Uicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uicondition"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uisequence"
        TargetTable =
         { Name = TableName "Uisequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceId"
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
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseNewBuffer"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequencesUistep"
                          Name = "UisequencesUisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uisequence"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UisequenceConfiguration"
        TargetTable =
         { Name = TableName "UisequenceConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceConfigurationId"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UisequenceConfiguration"
        IsNullable = false
        KeyType = Guid }] }-Uicondition-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uiconditions
                                    .Where(x => x.Uicondition != null && ids.Contains((Guid)x.Uicondition))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uicondition!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uicondition);
                });
            
			
                Field<UisequenceGraphType, Uisequence>("Uisequences")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisequenceGraphType>(
                            "{ Name = EntityName "UisequenceConfigurationsUisequence"
  CorrespondingTable =
   Regular
     { Name = TableName "UisequenceConfigurationsUisequence"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisequenceConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UisequenceId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "UiconditionId"
                                                         IsNullable = true };
         Navigation { Type = TableName "Uicondition"
                      Name = "Uicondition"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uisequence"
                      Name = "Uisequence"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisequenceConfiguration"
                      Name = "UisequenceConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UisequenceConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UisequenceId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uicondition"
        TargetTable =
         { Name = TableName "Uicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uicondition"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uisequence"
        TargetTable =
         { Name = TableName "Uisequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceId"
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
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseNewBuffer"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequencesUistep"
                          Name = "UisequencesUisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uisequence"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UisequenceConfiguration"
        TargetTable =
         { Name = TableName "UisequenceConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceConfigurationId"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UisequenceConfiguration"
        IsNullable = false
        KeyType = Guid }] }-Uisequence-loader",
                            async ids => 
                            {
                                var data = await dbContext.Uisequences
                                    .Where(x => x.Uisequence != null && ids.Contains((Guid)x.Uisequence))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Uisequence!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Uisequence);
                });
            
			
                Field<UisequenceConfigurationGraphType, UisequenceConfiguration>("UisequenceConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, UisequenceConfigurationGraphType>(
                            "{ Name = EntityName "UisequenceConfigurationsUisequence"
  CorrespondingTable =
   Regular
     { Name = TableName "UisequenceConfigurationsUisequence"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "UisequenceConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "UisequenceId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false }; ForeignKey { Type = Guid
                                                         Name = "UiconditionId"
                                                         IsNullable = true };
         Navigation { Type = TableName "Uicondition"
                      Name = "Uicondition"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Uisequence"
                      Name = "Uisequence"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "UisequenceConfiguration"
                      Name = "UisequenceConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "UisequenceConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "UisequenceId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Uicondition"
        TargetTable =
         { Name = TableName "Uicondition"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UiconditionId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UistepsUicondition"
                          Name = "UistepsUiconditions"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uicondition"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Uisequence"
        TargetTable =
         { Name = TableName "Uisequence"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceId"
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
             ForeignKey { Type = Byte
                          Name = "GireadTypeId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "GireadTypePosition"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Givalue"
                                                           IsNullable = false };
             Primitive { Type = Bool
                         Name = "UseNewBuffer"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UisequencesUistep"
                          Name = "UisequencesUisteps"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Uisequence"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "UisequenceConfiguration"
        TargetTable =
         { Name = TableName "UisequenceConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "UisequenceConfigurationId"
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
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UisequenceConfigurationsUisequence"
                          Name = "UisequenceConfigurationsUisequences"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "UisequenceConfiguration"
        IsNullable = false
        KeyType = Guid }] }-UisequenceConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.UisequenceConfigurations
                                    .Where(x => x.UisequenceConfiguration != null && ids.Contains((Guid)x.UisequenceConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.UisequenceConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.UisequenceConfiguration);
                });
            
        }
    }
}
            
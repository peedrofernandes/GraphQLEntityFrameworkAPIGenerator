
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
    public partial class SelectorConfigurationsSelectorGraphType : ObjectGraphType<SelectorConfigurationsSelector>
    {
        public SelectorConfigurationsSelectorGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.SelectorConfigurationId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.SelectorId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Index, type: typeof(ByteGraphType), nullable: False);
            
                Field<SelectorGraphType, Selector>("Selectors")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SelectorGraphType>(
                            "{ Name = EntityName "SelectorConfigurationsSelector"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfigurationsSelector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "SelectorId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "Selector"
                      Name = "Selector"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfiguration"
                      Name = "SelectorConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "SelectorId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Selector"
        TargetTable =
         { Name = TableName "Selector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "OffMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiuserFunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GlobalUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OffUimacroId"
                          IsNullable = true };
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "DelayUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "EndUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "GlobalUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "OffMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OffUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "PauseUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "ProgrammingUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfigurationsSelector"
                          Name = "SelectorConfigurationsSelectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorsCycle"
                          Name = "SelectorsCycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UiuserFunctionConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "Selector"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "SelectorConfiguration"
        TargetTable =
         { Name = TableName "SelectorConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
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
             Primitive { Type = String
                         Name = "Code"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UiuserFunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GlobalUimacroId"
                          IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "GlobalUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfigurationsSelector"
                          Name = "SelectorConfigurationsSelectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UiuserFunctionConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfiguration"
        IsNullable = false
        KeyType = Guid }] }-Selector-loader",
                            async ids => 
                            {
                                var data = await dbContext.Selectors
                                    .Where(x => x.Selector != null && ids.Contains((Guid)x.Selector))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Selector!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Selector);
                });
            
			
                Field<SelectorConfigurationGraphType, SelectorConfiguration>("SelectorConfigurations")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, SelectorConfigurationGraphType>(
                            "{ Name = EntityName "SelectorConfigurationsSelector"
  CorrespondingTable =
   Regular
     { Name = TableName "SelectorConfigurationsSelector"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "SelectorConfigurationId"
                      IsNullable = false }; PrimaryKey { Type = Guid
                                                         Name = "SelectorId"
                                                         IsNullable = false };
         PrimaryKey { Type = Byte
                      Name = "Index"
                      IsNullable = false };
         Navigation { Type = TableName "Selector"
                      Name = "Selector"
                      IsNullable = false
                      IsCollection = false };
         Navigation { Type = TableName "SelectorConfiguration"
                      Name = "SelectorConfiguration"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "SelectorConfigurationId"
      Type = Id Guid
      IsNullable = false }; { Name = "SelectorId"
                              Type = Id Guid
                              IsNullable = false }; { Name = "Index"
                                                      Type = Id Byte
                                                      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "Selector"
        TargetTable =
         { Name = TableName "Selector"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = String
                         Name = "Description"
                         IsNullable = false }; Primitive { Type = Byte
                                                           Name = "Status"
                                                           IsNullable = false };
             Primitive { Type = String
                         Name = "Owner"
                         IsNullable = false }; Primitive { Type = DateTime
                                                           Name = "Timestamp"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "OffMacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "UiuserFunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GlobalUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "ProgrammingUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "DelayUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "PauseUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "EndUimacroId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "OffUimacroId"
                          IsNullable = true };
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "DelayUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "EndUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "GlobalUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Macro"
                          Name = "OffMacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "OffUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "PauseUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Uimacro"
                          Name = "ProgrammingUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "SelectorConfigurationsSelector"
                          Name = "SelectorConfigurationsSelectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorsCycle"
                          Name = "SelectorsCycles"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UiuserFunctionConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "Selector"
        IsNullable = false
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "SelectorConfiguration"
        TargetTable =
         { Name = TableName "SelectorConfiguration"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "SelectorConfigurationId"
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
             Primitive { Type = String
                         Name = "Code"
                         IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "UiuserFunctionConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GlobalUimacroId"
                          IsNullable = true };
             Navigation { Type = TableName "Uimacro"
                          Name = "GlobalUimacro"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "SelectorConfigurationsSelector"
                          Name = "SelectorConfigurationsSelectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "UifunctionConfiguration"
                          Name = "UiuserFunctionConfiguration"
                          IsNullable = true
                          IsCollection = false }] }
        Destination = EntityName "SelectorConfiguration"
        IsNullable = false
        KeyType = Guid }] }-SelectorConfiguration-loader",
                            async ids => 
                            {
                                var data = await dbContext.SelectorConfigurations
                                    .Where(x => x.SelectorConfiguration != null && ids.Contains((Guid)x.SelectorConfiguration))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.SelectorConfiguration!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.SelectorConfiguration);
                });
            
        }
    }
}
            
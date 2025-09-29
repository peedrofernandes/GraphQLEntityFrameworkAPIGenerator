
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
    public partial class FaultDetailGraphType : ObjectGraphType<FaultDetail>
    {
        public FaultDetailGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.FaultDetailsId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.Code, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.SubCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.EngineeringCode, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.PauseCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.DirectToFault, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.HasSubCycle, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.Phase, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.AllowClearWithoutRemovingFault, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.ClearFaultAfterColdReset, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.CancelCycleOnly, type: typeof(BoolGraphType), nullable: False);
			Field(t => t.EngineeringCodeMethod, type: typeof(BoolGraphType), nullable: False);
            
                Field<DebounceMethodParameterGraphType, DebounceMethodParameter>("DebounceMethodParameters")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, DebounceMethodParameterGraphType>(
                            "{ Name = EntityName "FaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "FaultId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Code"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "SubCode"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "EngineeringCode"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "PauseCycle"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DirectToFault"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "FaultParametersId"
                      IsNullable = true }; Primitive { Type = Bool
                                                       Name = "HasSubCycle"
                                                       IsNullable = false };
         ForeignKey { Type = Int
                      Name = "SubCycleNameId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Phase"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DebounceParametersId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "TargetId"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "AllowClearWithoutRemovingFault"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "ClearFaultAfterColdReset"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "CancelCycleOnly"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EngineeringCodeMethod"
                     IsNullable = false };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceParameters"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                      Name = "FaultConfigurationsFaultDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Target"
                      Name = "Target"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultDetailsId"
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
    { Name = "Code"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SubCode"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "EngineeringCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PauseCycle"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DirectToFault"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "HasSubCycle"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Phase"
      Type = Primitive Byte
      IsNullable = false }; { Name = "AllowClearWithoutRemovingFault"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ClearFaultAfterColdReset"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CancelCycleOnly"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "EngineeringCodeMethod"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebounceMethodParameter"
        TargetTable =
         { Name = TableName "DebounceMethodParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebounceMethodParametersId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultPrescalarId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "FaultDelay"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedPrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedPrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedFaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedFaultDelay"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "FaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "FaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "PrefaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "PrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedFaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedPrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DebounceMethodParameter"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "FaultConfigurationsFaultDetail"
        TargetTable =
         { Name = TableName "FaultConfigurationsFaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Priority"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultConfiguration"
                          Name = "FaultConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultConfigurationsFaultDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Macro"
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Target"
        TargetTable =
         { Name = TableName "Target"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "TargetDsc"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Target"
        IsNullable = false
        KeyType = Byte }] }-DebounceMethodParameter-loader",
                            async ids => 
                            {
                                var data = await dbContext.DebounceMethodParameters
                                    .Where(x => x.DebounceMethodParameter != null && ids.Contains((Guid)x.DebounceMethodParameter))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.DebounceMethodParameter!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.DebounceMethodParameter);
                });
            
			
                Field<FaultConfigurationsFaultDetailGraphType, FaultConfigurationsFaultDetail>("FaultConfigurationsFaultDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultConfigurationsFaultDetailGraphType>>(
                            "{ Name = EntityName "FaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "FaultId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Code"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "SubCode"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "EngineeringCode"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "PauseCycle"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DirectToFault"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "FaultParametersId"
                      IsNullable = true }; Primitive { Type = Bool
                                                       Name = "HasSubCycle"
                                                       IsNullable = false };
         ForeignKey { Type = Int
                      Name = "SubCycleNameId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Phase"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DebounceParametersId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "TargetId"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "AllowClearWithoutRemovingFault"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "ClearFaultAfterColdReset"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "CancelCycleOnly"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EngineeringCodeMethod"
                     IsNullable = false };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceParameters"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                      Name = "FaultConfigurationsFaultDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Target"
                      Name = "Target"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultDetailsId"
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
    { Name = "Code"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SubCode"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "EngineeringCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PauseCycle"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DirectToFault"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "HasSubCycle"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Phase"
      Type = Primitive Byte
      IsNullable = false }; { Name = "AllowClearWithoutRemovingFault"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ClearFaultAfterColdReset"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CancelCycleOnly"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "EngineeringCodeMethod"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebounceMethodParameter"
        TargetTable =
         { Name = TableName "DebounceMethodParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebounceMethodParametersId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultPrescalarId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "FaultDelay"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedPrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedPrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedFaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedFaultDelay"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "FaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "FaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "PrefaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "PrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedFaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedPrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DebounceMethodParameter"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "FaultConfigurationsFaultDetail"
        TargetTable =
         { Name = TableName "FaultConfigurationsFaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Priority"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultConfiguration"
                          Name = "FaultConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultConfigurationsFaultDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Macro"
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Target"
        TargetTable =
         { Name = TableName "Target"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "TargetDsc"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Target"
        IsNullable = false
        KeyType = Byte }] }-FaultConfigurationsFaultDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultConfigurationsFaultDetails
                                    .Where(x => x.FaultConfigurationsFaultDetail != null && ids.Contains((Guid)x.FaultConfigurationsFaultDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultConfigurationsFaultDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.FaultConfigurationsFaultDetails);
                    });
            
			
                Field<MacroGraphType, Macro>("Macros")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, MacroGraphType>(
                            "{ Name = EntityName "FaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "FaultId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Code"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "SubCode"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "EngineeringCode"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "PauseCycle"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DirectToFault"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "FaultParametersId"
                      IsNullable = true }; Primitive { Type = Bool
                                                       Name = "HasSubCycle"
                                                       IsNullable = false };
         ForeignKey { Type = Int
                      Name = "SubCycleNameId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Phase"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DebounceParametersId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "TargetId"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "AllowClearWithoutRemovingFault"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "ClearFaultAfterColdReset"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "CancelCycleOnly"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EngineeringCodeMethod"
                     IsNullable = false };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceParameters"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                      Name = "FaultConfigurationsFaultDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Target"
                      Name = "Target"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultDetailsId"
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
    { Name = "Code"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SubCode"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "EngineeringCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PauseCycle"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DirectToFault"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "HasSubCycle"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Phase"
      Type = Primitive Byte
      IsNullable = false }; { Name = "AllowClearWithoutRemovingFault"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ClearFaultAfterColdReset"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CancelCycleOnly"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "EngineeringCodeMethod"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebounceMethodParameter"
        TargetTable =
         { Name = TableName "DebounceMethodParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebounceMethodParametersId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultPrescalarId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "FaultDelay"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedPrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedPrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedFaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedFaultDelay"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "FaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "FaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "PrefaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "PrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedFaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedPrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DebounceMethodParameter"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "FaultConfigurationsFaultDetail"
        TargetTable =
         { Name = TableName "FaultConfigurationsFaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Priority"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultConfiguration"
                          Name = "FaultConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultConfigurationsFaultDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Macro"
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Target"
        TargetTable =
         { Name = TableName "Target"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "TargetDsc"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Target"
        IsNullable = false
        KeyType = Byte }] }-Macro-loader",
                            async ids => 
                            {
                                var data = await dbContext.Macros
                                    .Where(x => x.Macro != null && ids.Contains((Guid)x.Macro))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Macro!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Macro);
                });
            
			
                Field<TargetGraphType, Target>("Targets")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, TargetGraphType>(
                            "{ Name = EntityName "FaultDetail"
  CorrespondingTable =
   Regular
     { Name = TableName "FaultDetail"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "FaultDetailsId"
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
                     IsNullable = true }; ForeignKey { Type = Byte
                                                       Name = "FaultId"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "Code"
                     IsNullable = false }; Primitive { Type = Byte
                                                       Name = "SubCode"
                                                       IsNullable = false };
         Primitive { Type = Byte
                     Name = "EngineeringCode"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "PauseCycle"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "DirectToFault"
                     IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "FaultParametersId"
                      IsNullable = true }; Primitive { Type = Bool
                                                       Name = "HasSubCycle"
                                                       IsNullable = false };
         ForeignKey { Type = Int
                      Name = "SubCycleNameId"
                      IsNullable = false }; Primitive { Type = Byte
                                                        Name = "Phase"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "DebounceParametersId"
                      IsNullable = true }; ForeignKey { Type = Byte
                                                        Name = "TargetId"
                                                        IsNullable = false };
         ForeignKey { Type = Guid
                      Name = "MacroId"
                      IsNullable = true };
         Primitive { Type = Bool
                     Name = "AllowClearWithoutRemovingFault"
                     IsNullable = false };
         Primitive { Type = Bool
                     Name = "ClearFaultAfterColdReset"
                     IsNullable = false }; Primitive { Type = Bool
                                                       Name = "CancelCycleOnly"
                                                       IsNullable = false };
         Primitive { Type = Bool
                     Name = "EngineeringCodeMethod"
                     IsNullable = false };
         Navigation { Type = TableName "DebounceMethodParameter"
                      Name = "DebounceParameters"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "FaultConfigurationsFaultDetail"
                      Name = "FaultConfigurationsFaultDetails"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Macro"
                      Name = "Macro"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "Target"
                      Name = "Target"
                      IsNullable = false
                      IsCollection = false }] }
  Fields =
   [{ Name = "FaultDetailsId"
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
    { Name = "Code"
      Type = Primitive Byte
      IsNullable = false }; { Name = "SubCode"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "EngineeringCode"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "PauseCycle"
      Type = Primitive Bool
      IsNullable = false }; { Name = "DirectToFault"
                              Type = Primitive Bool
                              IsNullable = false }; { Name = "HasSubCycle"
                                                      Type = Primitive Bool
                                                      IsNullable = false };
    { Name = "Phase"
      Type = Primitive Byte
      IsNullable = false }; { Name = "AllowClearWithoutRemovingFault"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "ClearFaultAfterColdReset"
      Type = Primitive Bool
      IsNullable = false }; { Name = "CancelCycleOnly"
                              Type = Primitive Bool
                              IsNullable = false };
    { Name = "EngineeringCodeMethod"
      Type = Primitive Bool
      IsNullable = false }]
  Relations =
   [SingleManyToOne
      { Name = RelationName "DebounceMethodParameter"
        TargetTable =
         { Name = TableName "DebounceMethodParameter"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "DebounceMethodParametersId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "PrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "PrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultDebounceMethodId"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "FaultPrescalarId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "FaultDelay"
                                                            IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedPrefaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedPrefaultDelay"
                         IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "RemovedFaultPrescalarId"
                          IsNullable = false };
             Primitive { Type = Byte
                         Name = "RemovedFaultDelay"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "FaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "FaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethod"
                          Name = "PrefaultDebounceMethod"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "PrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedFaultPrescalar"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "DebounceMethodPrescalar"
                          Name = "RemovedPrefaultPrescalar"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "DebounceMethodParameter"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "FaultConfigurationsFaultDetail"
        TargetTable =
         { Name = TableName "FaultConfigurationsFaultDetail"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "FaultConfigurationsId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "FaultDetailsId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Priority"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultConfiguration"
                          Name = "FaultConfigurations"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "FaultConfigurationsFaultDetail"
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Macro"
        TargetTable =
         { Name = TableName "Macro"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "MacroId"
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
                         Name = "Target"
                         IsNullable = false }; Primitive { Type = String
                                                           Name = "Comment"
                                                           IsNullable = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleDelayMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleEndMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CyclePauseMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Cycle"
                          Name = "CycleProgrammingMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "CyclesMacro"
                          Name = "CyclesMacros"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "MacrosStatement"
                          Name = "MacrosStatements"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "Selector"
                          Name = "Selectors"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Macro"
        IsNullable = true
        KeyType = Guid };
    SingleManyToOne
      { Name = RelationName "Target"
        TargetTable =
         { Name = TableName "Target"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "TargetId"
                          IsNullable = false }; Primitive { Type = String
                                                            Name = "TargetDsc"
                                                            IsNullable = false };
             Navigation { Type = TableName "FaultDetail"
                          Name = "FaultDetails"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "Target"
        IsNullable = false
        KeyType = Byte }] }-Target-loader",
                            async ids => 
                            {
                                var data = await dbContext.Targets
                                    .Where(x => x.Target != null && ids.Contains((byte)x.Target))
                                    .Select(x => new
                                    {
                                        Key = (byte)x.Target!,
                                        Value = x,
                                    })
                                    .ToListAsync();

                                return data.ToLookup(x => x.Key, x => x.Value);
                            });

                        return loader.LoadAsync(context.Source.Target);
                });
            
        }
    }
}
            
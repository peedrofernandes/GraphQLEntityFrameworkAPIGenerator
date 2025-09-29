
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
    public partial class DebounceMethodParameterGraphType : ObjectGraphType<DebounceMethodParameter>
    {
        public DebounceMethodParameterGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.DebounceMethodParametersId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.PrefaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.FaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RemovedPrefaultDelay, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RemovedFaultDelay, type: typeof(ByteGraphType), nullable: False);
            
                Field<DebounceMethodGraphType, DebounceMethod>("DebounceMethods")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, DebounceMethodGraphType>(
                            "{ Name = EntityName "DebounceMethodParameter"
  CorrespondingTable =
   Regular
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
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "DebounceMethodParametersId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrefaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "FaultDelay"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "RemovedPrefaultDelay"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RemovedFaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "FaultDebounceMethod";
          RelationName "PrefaultDebounceMethod"]
        TargetTable =
         { Name = TableName "DebounceMethod"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultDebounceMethods"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterPrefaultDebounceMethods"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethod"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "FaultDetail"
        TargetTable =
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
             ForeignKey { Type = Byte
                          Name = "FaultId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "FaultDetail"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "FaultPrescalar"; RelationName "PrefaultPrescalar";
          RelationName "RemovedFaultPrescalar";
          RelationName "RemovedPrefaultPrescalar"]
        TargetTable =
         { Name = TableName "DebounceMethodPrescalar"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodPrescalarId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodPrescalarDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterPrefaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterRemovedFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterRemovedPrefaultPrescalars"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethodPrescalar"
        IsNullable = false
        KeyType = Byte }] }-DebounceMethod-loader",
                            async ids => 
                            {
                                Expression<Func<DebounceMethod, bool>> expr = x => !ids.Any()
                                    \|\| (x.FaultDebounceMethod != null && ids.Contains((byte)x.FaultDebounceMethod))
\|\| (x.PrefaultDebounceMethod != null && ids.Contains((byte)x.PrefaultDebounceMethod));

                                var data = await dbContext.DebounceMethods
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.FaultDebounceMethod,
x.PrefaultDebounceMethod
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.DebounceMethods);
                    });
            
			
                Field<FaultDetailGraphType, FaultDetail>("FaultDetails")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<FaultDetailGraphType>>(
                            "{ Name = EntityName "DebounceMethodParameter"
  CorrespondingTable =
   Regular
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
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "DebounceMethodParametersId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrefaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "FaultDelay"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "RemovedPrefaultDelay"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RemovedFaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "FaultDebounceMethod";
          RelationName "PrefaultDebounceMethod"]
        TargetTable =
         { Name = TableName "DebounceMethod"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultDebounceMethods"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterPrefaultDebounceMethods"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethod"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "FaultDetail"
        TargetTable =
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
             ForeignKey { Type = Byte
                          Name = "FaultId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "FaultDetail"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "FaultPrescalar"; RelationName "PrefaultPrescalar";
          RelationName "RemovedFaultPrescalar";
          RelationName "RemovedPrefaultPrescalar"]
        TargetTable =
         { Name = TableName "DebounceMethodPrescalar"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodPrescalarId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodPrescalarDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterPrefaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterRemovedFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterRemovedPrefaultPrescalars"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethodPrescalar"
        IsNullable = false
        KeyType = Byte }] }-FaultDetail-loader",
                            async ids => 
                            {
                                var data = await dbContext.FaultDetails
                                    .Where(x => x.FaultDetail != null && ids.Contains((Guid)x.FaultDetail))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.FaultDetail!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.FaultDetails);
                    });
            
			
                Field<DebounceMethodPrescalarGraphType, DebounceMethodPrescalar>("DebounceMethodPrescalars")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<byte, DebounceMethodPrescalarGraphType>(
                            "{ Name = EntityName "DebounceMethodParameter"
  CorrespondingTable =
   Regular
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
                      IsNullable = false }; Primitive { Type = Byte
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
  Fields =
   [{ Name = "DebounceMethodParametersId"
      Type = Id Guid
      IsNullable = false }; { Name = "PrefaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }; { Name = "FaultDelay"
                                                      Type = Primitive Byte
                                                      IsNullable = false };
    { Name = "RemovedPrefaultDelay"
      Type = Primitive Byte
      IsNullable = false }; { Name = "RemovedFaultDelay"
                              Type = Primitive Byte
                              IsNullable = false }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "FaultDebounceMethod";
          RelationName "PrefaultDebounceMethod"]
        TargetTable =
         { Name = TableName "DebounceMethod"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultDebounceMethods"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterPrefaultDebounceMethods"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethod"
        IsNullable = false
        KeyType = Byte };
    OneToMany
      { Name = RelationName "FaultDetail"
        TargetTable =
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
             ForeignKey { Type = Byte
                          Name = "FaultId"
                          IsNullable = false }; Primitive { Type = Byte
                                                            Name = "Code"
                                                            IsNullable = false };
             Primitive { Type = Byte
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
                         IsNullable = false };
             Primitive { Type = Bool
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
        Destination = EntityName "FaultDetail"
        KeyType = Guid };
    MultipleManyToOne
      { Names =
         [RelationName "FaultPrescalar"; RelationName "PrefaultPrescalar";
          RelationName "RemovedFaultPrescalar";
          RelationName "RemovedPrefaultPrescalar"]
        TargetTable =
         { Name = TableName "DebounceMethodPrescalar"
           Properties =
            [PrimaryKey { Type = Byte
                          Name = "DebounceMethodPrescalarId"
                          IsNullable = false };
             Primitive { Type = String
                         Name = "DebounceMethodPrescalarDescription"
                         IsNullable = false };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterPrefaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "DebounceMethodParameter"
                          Name = "DebounceMethodParameterRemovedFaultPrescalars"
                          IsNullable = false
                          IsCollection = true };
             Navigation
               { Type = TableName "DebounceMethodParameter"
                 Name = "DebounceMethodParameterRemovedPrefaultPrescalars"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "DebounceMethodPrescalar"
        IsNullable = false
        KeyType = Byte }] }-DebounceMethodPrescalar-loader",
                            async ids => 
                            {
                                Expression<Func<DebounceMethodPrescalar, bool>> expr = x => !ids.Any()
                                    \|\| (x.FaultPrescalar != null && ids.Contains((byte)x.FaultPrescalar))
\|\| (x.PrefaultPrescalar != null && ids.Contains((byte)x.PrefaultPrescalar))
\|\| (x.RemovedFaultPrescalar != null && ids.Contains((byte)x.RemovedFaultPrescalar))
\|\| (x.RemovedPrefaultPrescalar != null && ids.Contains((byte)x.RemovedPrefaultPrescalar));

                                var data = await dbContext.DebounceMethodPrescalars
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<byte?>()
                                    {
                                        x.FaultPrescalar,
x.PrefaultPrescalar,
x.RemovedFaultPrescalar,
x.RemovedPrefaultPrescalar
                                    }.OfType<byte>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.DebounceMethodPrescalars);
                    });
            
        }
    }
}
            
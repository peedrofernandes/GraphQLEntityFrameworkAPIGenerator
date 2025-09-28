
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
    public partial class CycleMappingAcuTargetGraphType : ObjectGraphType<CycleMappingAcuTarget>
    {
        public CycleMappingAcuTargetGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.CycleMappingAcuTargetId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.NumberOfComparments, type: typeof(IdGraphType), nullable: False);
			Field(t => t.CycleMappingCavityParamsId1, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CycleMappingCavityParamsId2, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CycleMappingCavityParamsId3, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.CycleMappingCavityParamsId4, type: typeof(GuidGraphType), nullable: True);
            
                Field<CycleMappingCavityParamGraphType, CycleMappingCavityParam>("CycleMappingCavityParams")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, CycleMappingCavityParamGraphType>(
                            "{ Name = EntityName "CycleMappingAcuTarget"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingAcuTarget"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingAcuTargetId"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "NumberOfComparments"
                     IsNullable = false };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId1"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId2"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId3"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId4"
                     IsNullable = true };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId1Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId3Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId4Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMappings"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "CycleMappingAcuTargetId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfComparments"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "CycleMappingCavityParamsId1"
      Type = Primitive Guid
      IsNullable = true }; { Name = "CycleMappingCavityParamsId2"
                             Type = Primitive Guid
                             IsNullable = true };
    { Name = "CycleMappingCavityParamsId3"
      Type = Primitive Guid
      IsNullable = true }; { Name = "CycleMappingCavityParamsId4"
                             Type = Primitive Guid
                             IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CycleMappingCavityParamsId1Navigation";
          RelationName "CycleMappingCavityParamsId2Navigation";
          RelationName "CycleMappingCavityParamsId3Navigation";
          RelationName "CycleMappingCavityParamsId4Navigation"]
        TargetTable =
         { Name = TableName "CycleMappingCavityParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingCavityParamsId"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "ProbeRemovalTimeout"
                         IsNullable = false };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleMappingCavityParam"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        KeyType = Guid }] }-CycleMappingCavityParam-loader",
                            async ids => 
                            {
                                Expression<Func<CycleMappingCavityParam, bool>> expr = x => !ids.Any()
                                    \|\| (x.CycleMappingCavityParamsId1Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId1Navigation))
\|\| (x.CycleMappingCavityParamsId2Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId2Navigation))
\|\| (x.CycleMappingCavityParamsId3Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId3Navigation))
\|\| (x.CycleMappingCavityParamsId4Navigation != null && ids.Contains((Guid)x.CycleMappingCavityParamsId4Navigation));

                                var data = await dbContext.CycleMappingCavityParams
                                    .Where(expr)
                                    .ToListAsync();

                                var lookup = data
                                    .SelectMany(x => new List<Guid?>()
                                    {
                                        x.CycleMappingCavityParamsId1Navigation,
x.CycleMappingCavityParamsId2Navigation,
x.CycleMappingCavityParamsId3Navigation,
x.CycleMappingCavityParamsId4Navigation
                                    }.OfType<Guid>().Select(id => new { Key = id, Value = x }))
                                    .ToLookup(x => x.Key, x => x.Value);

                                return lookup;
                            });

                        return loader.LoadAsync(context.Source.CycleMappingCavityParams);
                    });
            
			
                Field<CycleMappingGraphType, CycleMapping>("CycleMappings")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<CycleMappingGraphType>>(
                            "{ Name = EntityName "CycleMappingAcuTarget"
  CorrespondingTable =
   Regular
     { Name = TableName "CycleMappingAcuTarget"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "CycleMappingAcuTargetId"
                      IsNullable = false };
         Primitive { Type = Int
                     Name = "NumberOfComparments"
                     IsNullable = false };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId1"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId2"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId3"
                     IsNullable = true };
         Primitive { Type = Guid
                     Name = "CycleMappingCavityParamsId4"
                     IsNullable = true };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId1Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId2Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId3Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMappingCavityParam"
                      Name = "CycleMappingCavityParamsId4Navigation"
                      IsNullable = true
                      IsCollection = false };
         Navigation { Type = TableName "CycleMapping"
                      Name = "CycleMappings"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "CycleMappingAcuTargetId"
      Type = Id Guid
      IsNullable = false }; { Name = "NumberOfComparments"
                              Type = Primitive Int
                              IsNullable = false };
    { Name = "CycleMappingCavityParamsId1"
      Type = Primitive Guid
      IsNullable = true }; { Name = "CycleMappingCavityParamsId2"
                             Type = Primitive Guid
                             IsNullable = true };
    { Name = "CycleMappingCavityParamsId3"
      Type = Primitive Guid
      IsNullable = true }; { Name = "CycleMappingCavityParamsId4"
                             Type = Primitive Guid
                             IsNullable = true }]
  Relations =
   [MultipleManyToOne
      { Names =
         [RelationName "CycleMappingCavityParamsId1Navigation";
          RelationName "CycleMappingCavityParamsId2Navigation";
          RelationName "CycleMappingCavityParamsId3Navigation";
          RelationName "CycleMappingCavityParamsId4Navigation"]
        TargetTable =
         { Name = TableName "CycleMappingCavityParam"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingCavityParamsId"
                          IsNullable = false };
             Primitive { Type = Int
                         Name = "ProbeRemovalTimeout"
                         IsNullable = false };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId1Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId2Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId3Navigations"
                 IsNullable = false
                 IsCollection = true };
             Navigation
               { Type = TableName "CycleMappingAcuTarget"
                 Name =
                  "CycleMappingAcuTargetCycleMappingCavityParamsId4Navigations"
                 IsNullable = false
                 IsCollection = true }] }
        Destination = EntityName "CycleMappingCavityParam"
        IsNullable = true
        KeyType = Guid };
    OneToMany
      { Name = RelationName "CycleMapping"
        TargetTable =
         { Name = TableName "CycleMapping"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "CycleMappingId"
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
                          Name = "ExportOptionId"
                          IsNullable = false }; Primitive { Type = Bool
                                                            Name = "IsConnected"
                                                            IsNullable = false };
             Primitive { Type = Int
                         Name = "DataModelVersion"
                         IsNullable = true }; Primitive { Type = Float
                                                          Name = "Version"
                                                          IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "CycleMappingFileInfoId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CycleMappingAcuTargetId"
                          IsNullable = true };
             Navigation { Type = TableName "CycleMappingAcuTarget"
                          Name = "CycleMappingAcuTarget"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "CycleMappingCycleOptionsConfiguration"
                 Name = "CycleMappingCycleOptionsConfigurations"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CycleMappingFileInfo"
                          Name = "CycleMappingFileInfo"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "CycleMappingExportOption"
                          Name = "ExportOption"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "MachineConfiguration"
                          Name = "MachineConfigurations"
                          IsNullable = false
                          IsCollection = true }] }
        Destination = EntityName "CycleMapping"
        KeyType = Guid }] }-CycleMapping-loader",
                            async ids => 
                            {
                                var data = await dbContext.CycleMappings
                                    .Where(x => x.CycleMapping != null && ids.Contains((Guid)x.CycleMapping))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.CycleMapping!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.CycleMappings);
                    });
            
        }
    }
}
            
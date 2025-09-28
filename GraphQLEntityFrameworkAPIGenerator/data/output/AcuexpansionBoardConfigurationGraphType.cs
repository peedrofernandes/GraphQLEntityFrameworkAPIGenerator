
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
    public partial class AcuexpansionBoardConfigurationGraphType : ObjectGraphType<AcuexpansionBoardConfiguration>
    {
        public AcuexpansionBoardConfigurationGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.AcuexpansionBoardConfigId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
            
                Field<AcuexpansionBoardConfigurationsBoardGraphType, AcuexpansionBoardConfigurationsBoard>("AcuexpansionBoardConfigurationsBoards")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<AcuexpansionBoardConfigurationsBoardGraphType>>(
                            "{ Name = EntityName "AcuexpansionBoardConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "AcuexpansionBoardConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "AcuexpansionBoardConfigId"
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
                     IsNullable = true };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Board"
                      Name = "Boards"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "AcuexpansionBoardConfigId"
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
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Board"
        TargetTable =
         { Name = TableName "Board"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "BoardId"
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
             ForeignKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "AcuexpansionBoardConfigurationId"
                          IsNullable = true }; Primitive { Type = Byte
                                                           Name = "NodeAddress"
                                                           IsNullable = false };
             Primitive { Type = Long
                         Name = "StartPosition"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Size"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ReadableFlash"
                         IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "DefaultPinConfiguration"
                          Name = "DefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Board"
        KeyType = Guid }] }-AcuexpansionBoardConfigurationsBoard-loader",
                            async ids => 
                            {
                                var data = await dbContext.AcuexpansionBoardConfigurationsBoards
                                    .Where(x => x.AcuexpansionBoardConfigurationsBoard != null && ids.Contains((Guid)x.AcuexpansionBoardConfigurationsBoard))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.AcuexpansionBoardConfigurationsBoard!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.AcuexpansionBoardConfigurationsBoards);
                    });
            
			
                Field<BoardGraphType, Board>("Boards")
                    .ResolveAsync(context => 
                    {
                        var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<Guid, IEnumerable<BoardGraphType>>(
                            "{ Name = EntityName "AcuexpansionBoardConfiguration"
  CorrespondingTable =
   Regular
     { Name = TableName "AcuexpansionBoardConfiguration"
       Properties =
        [PrimaryKey { Type = Guid
                      Name = "AcuexpansionBoardConfigId"
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
                     IsNullable = true };
         Navigation { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                      Name = "AcuexpansionBoardConfigurationsBoards"
                      IsNullable = false
                      IsCollection = true };
         Navigation { Type = TableName "Board"
                      Name = "Boards"
                      IsNullable = false
                      IsCollection = true }] }
  Fields =
   [{ Name = "AcuexpansionBoardConfigId"
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
                                                      IsNullable = true }]
  Relations =
   [OneToMany
      { Name = RelationName "AcuexpansionBoardConfigurationsBoard"
        TargetTable =
         { Name = TableName "AcuexpansionBoardConfigurationsBoard"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "AcuexpansionBoardConfigId"
                          IsNullable = false };
             PrimaryKey { Type = Guid
                          Name = "BoardId"
                          IsNullable = false };
             PrimaryKey { Type = Byte
                          Name = "Index"
                          IsNullable = false };
             ForeignKey { Type = Byte
                          Name = "AcuexpansionBoardId"
                          IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfig"
                          IsNullable = false
                          IsCollection = false };
             Navigation { Type = TableName "Board"
                          Name = "Board"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "AcuexpansionBoardConfigurationsBoard"
        KeyType = Guid };
    OneToMany
      { Name = RelationName "Board"
        TargetTable =
         { Name = TableName "Board"
           Properties =
            [PrimaryKey { Type = Guid
                          Name = "BoardId"
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
             ForeignKey { Type = Guid
                          Name = "LoadConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "LowLevelInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "GenericInputConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "CrossLoadConfigurationId"
                          IsNullable = true };
             ForeignKey { Type = Guid
                          Name = "AcuexpansionBoardConfigurationId"
                          IsNullable = true }; Primitive { Type = Byte
                                                           Name = "NodeAddress"
                                                           IsNullable = false };
             Primitive { Type = Long
                         Name = "StartPosition"
                         IsNullable = false }; Primitive { Type = Int
                                                           Name = "Size"
                                                           IsNullable = false };
             ForeignKey { Type = Guid
                          Name = "DefaultPinConfigurationId"
                          IsNullable = true };
             Primitive { Type = Byte
                         Name = "ReadableFlash"
                         IsNullable = false };
             Navigation { Type = TableName "AcuexpansionBoardConfiguration"
                          Name = "AcuexpansionBoardConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation
               { Type = TableName "AcuexpansionBoardConfigurationsBoard"
                 Name = "AcuexpansionBoardConfigurationsBoards"
                 IsNullable = false
                 IsCollection = true };
             Navigation { Type = TableName "CrossLoadConfiguration"
                          Name = "CrossLoadConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "DefaultPinConfiguration"
                          Name = "DefaultPinConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "GenericInputConfiguration"
                          Name = "GenericInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LoadConfiguration"
                          Name = "LoadConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "LowLevelInputConfiguration"
                          Name = "LowLevelInputConfiguration"
                          IsNullable = true
                          IsCollection = false };
             Navigation { Type = TableName "Project"
                          Name = "Projects"
                          IsNullable = false
                          IsCollection = true };
             Navigation { Type = TableName "TableTarget"
                          Name = "TableTargetNavigation"
                          IsNullable = false
                          IsCollection = false }] }
        Destination = EntityName "Board"
        KeyType = Guid }] }-Board-loader",
                            async ids => 
                            {
                                var data = await dbContext.Boards
                                    .Where(x => x.Board != null && ids.Contains((Guid)x.Board))
                                    .Select(x => new
                                    {
                                        Key = (Guid)x.Board!,
                                        Value = x,
                                    })
                                    .ToListAsync();
                            });

                        return loader.LoadAsync(context.Source.Boards);
                    });
            
        }
    }
}
            
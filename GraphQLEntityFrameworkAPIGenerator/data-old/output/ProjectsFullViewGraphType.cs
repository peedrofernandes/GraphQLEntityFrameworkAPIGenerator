
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
    public partial class ProjectsFullViewGraphType : ObjectGraphType<ProjectsFullView>
    {
        public ProjectsFullViewGraphType(GESECookingContext dbContext, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.ProjectId, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Description, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Status, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Owner, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Timestamp, type: typeof(DateTimeGraphType), nullable: False);
			Field(t => t.IndustrialCode, type: typeof(StringGraphType), nullable: False);
			Field(t => t.ProductType, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ProductCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ProductRevision, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ModelName, type: typeof(StringGraphType), nullable: False);
			Field(t => t.Comment, type: typeof(StringGraphType), nullable: True);
			Field(t => t.BoardId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.DisplayId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.SelectorConfigurationId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.MachineConfigurationId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ProductTypeId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.RevisionGroup, type: typeof(GuidGraphType), nullable: False);
			Field(t => t.Revision, type: typeof(IdGraphType), nullable: False);
			Field(t => t.TableTarget, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.Notes, type: typeof(StringGraphType), nullable: True);
			Field(t => t.BoardCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.BoardDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DisplayCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.DisplayDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SelectorConfigurationDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.MachineConfigurationCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.MachineConfigurationDescription, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SelectorConfigurationCode, type: typeof(StringGraphType), nullable: True);
			Field(t => t.ChangeActivityNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SoftwarePartNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.SoftwareCodeNumber, type: typeof(StringGraphType), nullable: True);
			Field(t => t.GeneratorVersion, type: typeof(StringGraphType), nullable: True);
			Field(t => t.WindchillDescriptionObjectVersion, type: typeof(ShortGraphType), nullable: False);
			Field(t => t.WindchillStatusId, type: typeof(ByteGraphType), nullable: False);
			Field(t => t.StartPosition, type: typeof(LongGraphType), nullable: True);
			Field(t => t.Size, type: typeof(IdGraphType), nullable: True);
			Field(t => t.HmiConfigurationId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.AcuConfigurationId, type: typeof(GuidGraphType), nullable: True);
			Field(t => t.ProductTypeDsc, type: typeof(StringGraphType), nullable: True);
            
        }
    }
}
            
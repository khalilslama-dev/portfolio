namespace Types;

public class ResumeModel {
  public string? About { get; set; }
  public UserModel? User { get; set;}
  public List<ExperienceModel>? Experiences { get; set; }
  public List<EducationModel>? Educations { get; set; }
  public List<ServiceModel>? Services { get; set; }

  public List<SkillModel>? Skills { get; set; }
}
public class ExperienceModel
{
  public string? CompanyName { get; set; }
  public string? Tenure { get; set; }

  public string? Description { get; set; }
  public string? Title { get; set; }
}

public class EducationModel
{
  public string? Name { get; set; }
  public string? DegreeYear { get; set; }
  public string? Description { get; set; }
}
public class ServiceModel
{
  public string? icon { get; set; }
  public string? Name { get; set; }
  public string? Description { get; set; }
}

public class SkillModel
{
  public string? Name { get; set; }
  public int? EstimatedLevel { get; set; }
  public string? EstimatedDescription { get; set; }
}

public class UserModel
{
  public string? FullName {get; set;}
  public string? Email {get; set;}
  public string? Profession {get; set;}
  public string? Github {get; set;}
  public string? Linkedin {get; set;}
  public string? Image {get; set;}
}

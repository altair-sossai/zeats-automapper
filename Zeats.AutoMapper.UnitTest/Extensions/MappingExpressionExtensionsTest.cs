using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeats.AutoMapper.Extensions;

namespace Zeats.AutoMapper.UnitTest.Extensions;

[TestClass]
public class MappingExpressionExtensionsTest
{
    private Mapper _mapper;

    [TestInitialize]
    public void Initialize()
    {
        var configuration = new MapperConfiguration(c => { c.AddProfile<CustomProfile>(); });

        _mapper = new Mapper(configuration);
    }

    [TestMethod]
    public void ForMember()
    {
        var source = new Source { Name = "Lorem Ipsum" };
        var target = _mapper.Map<Target>(source);

        Assert.IsNotNull(target);

        Assert.AreEqual(source.Name, target.CompanyName);
        Assert.AreEqual("fixed-value", target.Document);
    }

    private class Source
    {
        public string Name { get; set; }
    }

    public class Target
    {
        public string CompanyName { get; set; }
        public string Document { get; set; }
    }

    private class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Source, Target>()
                .ForMember(t => t.CompanyName, s => s.Name)
                .ForMember(t => t.Document, "fixed-value");
        }
    }
}
using System;
using System.Linq.Expressions;
using AutoMapper;

namespace Zeats.AutoMapper.Extensions;

public static class MappingExpressionExtensions
{
    public static IMappingExpression<TSource, TDestination> ForMember<TSource, TDestination, TMember, TSourceMember>(
        this IMappingExpression<TSource, TDestination> mappingExpression,
        Expression<Func<TDestination, TMember>> destinationMember,
        Expression<Func<TSource, TSourceMember>> mapExpression)
    {
        return mappingExpression
            .ForMember(destinationMember, options => options.MapFrom(mapExpression));
    }

    public static IMappingExpression<TSource, TDestination> ForMember<TSource, TDestination, TMember, TValue>(
        this IMappingExpression<TSource, TDestination> mappingExpression,
        Expression<Func<TDestination, TMember>> destinationMember,
        TValue value)
    {
        return mappingExpression
            .ForMember(destinationMember, options => options.MapFrom(m => value));
    }
}
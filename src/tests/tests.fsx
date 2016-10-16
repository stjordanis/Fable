// This file is a replacemente for Fable.Tests.fsproj
// as Fable NetCore version cannot read fsproj files

#r "System.Threading.dll"
#r "System.Text.RegularExpressions.dll"
#r "../../packages/NUnit/lib/dotnet/nunit.framework.dll"
#r "../../build/fable/bin/Fable.Core.dll"

#load
    "DllRef/Util/Util.fs"
    "DllRef/Lib.fs"
    "Other/Util/Util.fs"
    "Util/Util.fs"
    "Util/Util2.fs"
    "../tests_external/Util3.fs"
    "../tests_external/Util4.fs"
    "ArithmeticTests.fs"
    "ArrayTests.fs"
    "AsyncTests.fs"
    "ComparisonTests.fs"
    "ConvertTests.fs"
    "DateTimeTests.fs"
    "DictionaryTests.fs"
    "EnumTests.fs"
    "EventTests.fs"
    "HashSetTests.fs"
    "JsonTests.fs"
    "ListTests.fs"
    "MapTests.fs"
    "MiscTests.fs"
    "ObservableTests.fs"
    "RecordTypeTests.fs"
    "ReflectionTests.fs"
    "RegexTests.fs"
    "ResizeArrayTests.fs"
    "SeqExpressionTests.fs"
    "SeqTests.fs"
    "SetTests.fs"
    "StringTests.fs"
    "SudokuTest.fs"
    "TupleTypeTests.fs"
    "TypeTests.fs"
    "UnionTypeTests.fs"
# Third-Party Notices — xxxModelShredder

This tree is Dave Robinson's working copy of Johannes Rudolph's C#
ModelShredder library (Google Code project `modelshredder`, SVN trunk
checkout). There is no separable VaderConsulting wrapper. Do not treat
the library source as VaderConsulting MIT-licensed original work.

## Johannes Rudolph / ModelShredder (2009)

C# 3.5 class library that converts an `IEnumerable` of objects into a
`System.Data.DataTable` by reflecting public fields and properties once,
then emitting a `DynamicMethod` (`InjectionObjectShredder`) that copies
member values into `object[]` rows. A WinForms demo
(`Model Shredder Demo`) generates 100,000 `TestObj` instances and binds
them through `ToDataTable()`.

- Original project: http://code.google.com/p/modelshredder/
- Archive: https://code.google.com/archive/p/modelshredder/
- SVN: https://modelshredder.googlecode.com/svn/trunk
- Author: Johannes Rudolph (Google Code / SVN author `jojo.rudolph`)
- Assembly copyright: Copyright ©  2009; empty `AssemblyCompany`
- Author's stated license (Stack Overflow, 2009): LGPL
  https://stackoverflow.com/questions/1232553/how-can-i-improve-my-first-oss-project

No license file was present in the OneDrive Historical Dev folder.
Original publication terms remain with Johannes Rudolph. Later ToDataTable
helpers were merged into MoreLINQ (Apache License 2.0); this folder is the
2009 Google Code trunk, not the MoreLINQ tree.

## Visual Studio conversion artefacts

`trunk/UpgradeLog.XML` and `trunk/UpgradeLog.htm` are gitignored (local
disk paths); redacted `trunk/UpgradeLog.XML.example` and
`trunk/UpgradeLog.htm.example` are committed. `_UpgradeReport_Files/` and
`Backup/` are Visual Studio 2012 conversion output dated Thursday 20 June
2013 (solution format 10.00 / VS 2008 → 12.00 / VS 2012, ToolsVersion
3.5 → 4.0). Those are tooling artefacts, not a separate third-party product.

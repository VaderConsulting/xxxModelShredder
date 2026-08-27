# xxxModelShredder

Dave Robinson's working copy of Johannes Rudolph's C# ModelShredder that turns IEnumerable objects into DataTables via IL emit. `Shredder` takes an `IShredderOptionsProvider`, `IObjectShredder`, and `ISchemaBuilder`; `InjectionObjectShredder` emits a `DynamicMethod` (`toObjectArray` plus the source type name) that boxes public fields and properties into `object[]` rows, while `DefaultSchemaBuilder` maps those members onto `DataColumn`s (nullable value types become `AllowDBNull`). `ModelShredder.Demo` is a WinForms form titled “Model Shredder Demo” whose `Populate!` button binds `TestObjects.List` (100,000 `TestObj` instances) through the `ToDataTable()` extension into `dgvMain`. Visual Studio conversion logs dated Thursday, 20 June 2013 record the ToolsVersion 3.5 → 4.0 / solution format 10.00 (VS 2008) → 12.00 (VS 2012) upgrade of an SVN trunk checkout from `https://modelshredder.googlecode.com/svn/trunk`.

**Source last updated:** 2013-06-20 · **Language:** C# · **Target:** .NET Framework 3.5 (ProductVersion 9.0.21022, ToolsVersion 4.0 after VS 2012 conversion) · **Output:** class library (`Library`) plus WinForms demo executable (`WinExe`)

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `ModelShredder` (`trunk/ModelShredder/ModelShredder.csproj`) | C# | Class library | `Shredder.Shred(IEnumerable)` → `DataTable`; IL-emit `InjectionObjectShredder`, `DefaultShredderOptionsProvider` (public fields then properties), `DefaultSchemaBuilder`. |
| `ModelShredder.Demo` (`trunk/ModelShredder.Demo/ModelShredder.Demo.csproj`) | C# | WinForms exe | Demo form; `IEnumerableExtensions.ToDataTable()`; `TestObj` / 100k-row `TestObjects.List` bound to a DataGridView. |

`trunk/` is the Google Code SVN working copy (13 items including `.svn`, ReSharper caches, and VS conversion artefacts). `Backup/` is the VS 2012 conversion copy of the VS 2008 tree. Keep `_UpgradeReport_Files` as conversion provenance. `UpgradeLog.XML` and `UpgradeLog.htm` are gitignored (local disk paths); redacted `.example` files are committed. `.svn/` / `_ReSharper*` / `*.suo` / `*.user` / `bin/` / `obj/` / `.vs/` are gitignored.

## How to open

Open `trunk/ModelShredder.sln` in Visual Studio 2012 or later (solution format 12.00 / Visual Studio 2012). Targets .NET Framework 3.5. The demo form `Demo` (`Text = "Model Shredder Demo"`) calls `TestObjects.List.ToDataTable()` on **Populate!** and shows the row count in `lblCount`. `trunk/Backup/ModelShredder.sln` opens the pre-upgrade Visual Studio 2008 copy.

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `xxxModelShredder` of Johannes Rudolph's ModelShredder library (Google Code, 2009). See `THIRD_PARTY_NOTICES.md`.

- **Original author:** Johannes Rudolph (Google Code / SVN author `jojo.rudolph`)
- **Original project:** http://code.google.com/p/modelshredder/ (archive: https://code.google.com/archive/p/modelshredder/)
- **SVN:** https://modelshredder.googlecode.com/svn/trunk (rev 11, 2009-04-12)
- **Assembly title / product:** ModelShredder, ModelShredderDemo
- **Assembly company:** (empty)
- **Assembly copyright:** Copyright ©  2009
- **Assembly version:** 1.0.0.0
- **Upgrade log:** Thursday, 20 June 2013 10:42 AM (redacted `trunk/UpgradeLog.XML.example`)
- **Later lineage:** ToDataTable helpers were later merged into MoreLINQ (Apache License)

## License

Original Johannes Rudolph / Google Code ModelShredder terms: LGPL (author's 2009 Stack Overflow notice; no license file in the OneDrive folder). This repository does **not** relicense the tree as VaderConsulting MIT. There is no separable Dave Robinson wrapper. See `LICENSE` and `THIRD_PARTY_NOTICES.md`.

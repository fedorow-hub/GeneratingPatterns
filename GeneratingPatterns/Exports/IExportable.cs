namespace GeneratingPatterns.Exports
{
    internal interface IExportable
    {
        void accept(IExportVisitor v);
    }
}

namespace StringLanguageExtensions.Containers
{
    /// <summary>
    /// 
    /// </summary>
    public class CharIndexed
    {
        public char Char { get; set; }
        public int Index { get; set; }

        public override string ToString()
        {
            return $"{{ Char = {Char}, Index = {Index} }}";
        }
    }
}

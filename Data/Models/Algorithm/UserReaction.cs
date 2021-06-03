namespace Data.Models.Algorithm
{
    /// <summary>
    /// Reakcje użytkownika na dane słowo kluczowe
    /// </summary>
    public class UserReaction
    {
        public int Id { get; set; }
        
        /// <summary>
        /// Id użytkownika
        /// </summary>
        public string UserId { get; set; }
        
        /// <summary>
        /// Słowo kluczowe pobrane z tematu
        /// </summary>
        public string Keyword { get; set; }
        
        /// <summary>
        /// Ile razy użytkownik dokonał interakcji z tematem o tym słowie kluczowym?
        /// </summary>
        public int PositiveCount { get; set; } 
        
        /// <summary>
        /// Ile razy użytkownik pominął temat o tym słowie kluczowym?
        /// </summary>
        public int NegativeCount { get; set; }
    }
}
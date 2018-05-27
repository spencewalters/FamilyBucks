namespace FamilyBucksProgram
{
    class FreeFamilyBuck : FamilyBucksProgram
    {
        public string Name { get => "Free Family Buck"; }
        public string ID { get => "9317AAF9-D4CF-45FF-B1D3-C6D56298C804"; }
        public FamilyBucksPlayLimitation PlayLimitation { get => FamilyBucksPlayLimitation.Per_Day; }
        public int Limit { get => limit; }

        private int limit = 1;
    }
}

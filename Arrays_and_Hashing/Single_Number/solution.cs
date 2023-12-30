public int SingleNumber(int[] nums) {
    Dictionary<int, int> digits = new Dictionary<int, int>();
    foreach (int val in nums)
    {
        // add each item to the array as a key
        if (!digits.TryAdd(val, val))
        {
            // if it already exists, remove it      
            digits.Remove(val);
        }                              
    }

    // remove the remaing odd number out - the only 1
    return digits.Values.First();        
}

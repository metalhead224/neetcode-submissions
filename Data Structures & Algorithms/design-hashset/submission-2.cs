public class MyHashSet {
    private int keyRange;
    private LinkedList<int>[] buckets;

    public MyHashSet() {
        keyRange = 10007;
        buckets = new LinkedList<int>[keyRange];

        for (int i = 0; i < keyRange; i++)
        {
            buckets[i] = new LinkedList<int>();
        }
    }

    private int GetBucketIndex(int key)
    {
        return key % keyRange;
    }
    
    public void Add(int key) {
        int index = GetBucketIndex(key);
        LinkedList<int> bucket = buckets[index];

        if (!bucket.Contains(key))
        {
            bucket.AddFirst(key);
        }
    }
    
    public void Remove(int key) {
        int index = GetBucketIndex(key);
        LinkedList<int> bucket = buckets[index];

        bucket.Remove(key);
    }
    
    public bool Contains(int key) {
        int index = GetBucketIndex(key);
        return buckets[index].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
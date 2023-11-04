public class Solution
    {
        // Time Complexity : O(2^m+n)
        // Space Complexity : O(m + n) - height of the tree
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No

        IList<IList<int>> result;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            result = new List<IList<int>>();
            helper(candidates, target, 0, new List<int>());
            return result;
        }

        private void helper(int[] candidates, int target, int idx, List<int> path)
        {
            //base case
            if (target < 0 || idx == candidates.Length) return;
            if (target == 0)
            {
                result.Add(new List<int>(path));
                return;
            }

            //logic
            //no choose
            helper(candidates, target, idx + 1, path);
            //choose
            //action
            path.Add(candidates[idx]);

            //recurse
            helper(candidates, target - candidates[idx], idx, path);

            //backtrack
            path.RemoveAt(path.Count - 1);
        }
}

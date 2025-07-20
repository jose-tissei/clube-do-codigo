public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var resp = new int[nums.Length];
        var prefixo = 1; 
        for (var i=0; i < nums.Length; i++)
        {
            resp[i] = prefixo;
            prefixo = prefixo * nums[i];
        }
        
        var sufixo = 1;
        for (var i = nums.Length -1; i>=0; i--)
        {
            resp[i] = resp[i] * sufixo; 
            sufixo = sufixo * nums[i];
        }
        return resp;

    }
}

export default function two_crystal_balls (breaks: boolean[]): number {

  // check to see if we can exit right away
  if (breaks.length == 1) {
    return 1;
  }
  
  // to get O(sqrt N) we have to jump by that value then search when we get our first "break" or true value
  const jumpDist = Math.floor(Math.sqrt(breaks.length));

  // find what interval the first egg breaks at
  let i = jumpDist; 
  for (;i < breaks.length; i += jumpDist) {
    if (breaks[i]) {
      // once we find the interval, leave the loop
      break;
    }
  }

  // go back one interval to before the break
  i -= jumpDist;

  // linear search up to the next interval or end for the breakpoint
  for (let j = 0; j < jumpDist && i < breaks.length; ++j, ++i) {
    if (breaks[i]) {
      return i;
    }
  }

  // we didn't find any breakpoints
  return -1;
}

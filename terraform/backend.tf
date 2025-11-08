terraform {
  backend "s3" {
    bucket       = "test-marathonepam2025"
    key          = "test-marathonepam2025"
    region       = "eu-central-1"
    use_lockfile = true
    encrypt      = true
  }
}
